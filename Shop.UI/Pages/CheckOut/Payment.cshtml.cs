 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Shop.Application.Cart;
using Shop.Application.Oders;
using Shop.Database;
using Shop.Domain.Infrastructure;
using Stripe;
using GetOrderCart = Shop.Application.Cart.GetOrder;

namespace Shop.UI.Pages.CheckOut
{
    
    public class PaymentModel : PageModel
    {
        public string PublicKey { get; }

        public PaymentModel(IConfiguration config)
        {
            PublicKey = config["Stripe:PublicKey"].ToString();
            
    }
       

        public IActionResult OnGet([FromServices] GetCustomerInformation getCustomerInformation)
        {
            //Get customer information
            var information = getCustomerInformation.Do();

            //If customer information is available, go to payment page 
            if (information == null)
            {
                return RedirectToPage("/CheckOut/CustomerInformation");
            }
            return Page();
        }

        public async Task<IActionResult> OnPost(
            string stripeEmail, 
            string stripeToken,
            [FromServices] GetOrderCart getOrder,
            [FromServices]  CreateOrder createOrder,
            [FromServices]  ISessionManager sessionManager)
        {
            var customers = new CustomerService();
            var charges = new ChargeService(); 
            var cartOrder = getOrder.Do();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = cartOrder.GetTotalCharge(),//this is same as $5, valus is an integer
                Description = "Shop Purchase",
                Currency = "usd",
                Customer = customer.Id
            });

            //Create a session for user's order
            var sessionId = HttpContext.Session.Id;

            //Create order
            await createOrder.Do(new CreateOrder.Request
            {
                StripeReference = charge.Id,

                //passing session in request
                SessionId = sessionId,

                FirstName = cartOrder.CustomerInformation.FirstName,
                LastName = cartOrder.CustomerInformation.LastName,
                Email = cartOrder.CustomerInformation.Email,
                PhoneNumber = cartOrder.CustomerInformation.PhoneNumber,
                Address1 = cartOrder.CustomerInformation.Address1,
                Address2 = cartOrder.CustomerInformation.Address2,
                City = cartOrder.CustomerInformation.City,
                PostCode = cartOrder.CustomerInformation.PostCode,

                Stocks = cartOrder.Products.Select(x => new CreateOrder.Stock
                {
                    StockId = x.StockId,
                    Qty = x.Qty
                }).ToList()

            });

            sessionManager.ClearCart();

            return RedirectToPage("/Index"); 
        }
    }
}