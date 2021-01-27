using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Database;

namespace Shop.UI.Pages.CheckOut
{
    public class CustomerInformationModel : PageModel
    {
        private IHostingEnvironment _env;

        public CustomerInformationModel(IHostingEnvironment env)
        {
            _env = env;
        }
       
        [BindProperty]
        public AddCustomerInformation.Request CustomerInformation { get; set; }

        public IActionResult OnGet([FromServices] GetCustomerInformation getCustomerInformation)
        {
            //Get customer information
            var information = getCustomerInformation.Do();

            //If customer information is available, go to payment page 
            if (information == null)
            { 
                if(_env.IsDevelopment())
                {
                    CustomerInformation = new AddCustomerInformation.Request
                    {
                        FirstName = "A",
                        LastName = "Ab",
                        Email = "A@gmail.com",
                        Phonenumber = "11",
                        Address1 = "bA",
                        Address2 = "cA",
                        City = "Aza",
                        PostCode = "Apt",
                    };
                }
            
                return Page();
            }
            else
            {
                return RedirectToPage("/CheckOut/Payment");
            }
        }

        public IActionResult OnPost([FromServices] AddCustomerInformation addCustomerInformation)
        {
            //Post Cart
            if (!ModelState.IsValid)
            {
                return Page();
            }

            addCustomerInformation.Do(CustomerInformation);

            return RedirectToPage("/CheckOut/Payment");

        }
    }
} 