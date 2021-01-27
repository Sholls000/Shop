using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Domain.Infrastructure;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.UI.Infrastructure
{
    public class SessionManager : ISessionManager
    {
        private const string KeyCart = "cart";
        private const string KeyCustomerInfo = "customer-info";
        private readonly ISession _session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            //injecting HttpContext into the sessions service layer
            _session = httpContextAccessor.HttpContext.Session;
        }


        public void AddProduct(CartProduct cartProduct)
        {
            //write the CartProduct to a list
            var cartList = new List<CartProduct>();

            //Loading the cart in the next two lines
            var stringObject = _session.GetString(KeyCart);


            if (!string.IsNullOrEmpty(stringObject))
            {
                cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            }
            if (cartList.Any(x => x.StockId == cartProduct.StockId))
            {
                cartList.Find(x => x.StockId == cartProduct.StockId).Qty += cartProduct.Qty;
            }
            else
            {
                cartList.Add(cartProduct);
            }

            //Serialize the cart details, then add to sessions
            stringObject = JsonConvert.SerializeObject(cartList);

            _session.SetString(KeyCart, stringObject);
        }

        public string GetId() => _session.Id;
      

        public IEnumerable<TResult> GetCart<TResult>(Func<CartProduct, TResult> selector)
        {
            var stringObject = _session.GetString(KeyCart); 

            if (string.IsNullOrEmpty(stringObject))
                return new List<TResult>();


            var cartList = JsonConvert.DeserializeObject<IEnumerable<CartProduct>>(stringObject);
            return cartList.Select(selector);
        }

        public void AddCustomerInformation(CustomerInformation customer)
        {
            //storing customerInformation to _session
            //Serialize the cart details, then add to sessions
            var stringObject = JsonConvert.SerializeObject(customer);

            _session.SetString(KeyCustomerInfo, stringObject);
        }

        public CustomerInformation GetCustomerInformation()
        {

            var stringObject = _session.GetString(KeyCustomerInfo);

            if (string.IsNullOrEmpty(stringObject))
                return null;


            //deSerialize the cart details, then add to sessions
            var customerInformation = JsonConvert.DeserializeObject<CustomerInformation>(stringObject);

            return customerInformation;

        }
        //clearing the cart after placing orders, using Session Manager
        public void ClearCart()
        {
            _session.Remove(KeyCart);
        }

        public void RemoveProduct(int stockId, int qty)
        {
            //setting the held stockOnHold to Sessions.


            //write the CartProduct to a list
            var cartList = new List<CartProduct>();

            //Loading the cart in the next three lines
            var stringObject = _session.GetString(KeyCart);
            if (string.IsNullOrEmpty(stringObject))  return;

            
            cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            if (!cartList.Any(x => x.StockId == stockId))    return;

            var product = cartList.First(x => x.StockId == stockId);
            product.Qty -= qty;

            if(product.Qty <= 0)
            {
                cartList.Remove(product);
            }

            //Serialize the cart details, then add to sessions
            stringObject = JsonConvert.SerializeObject(cartList);

            _session.SetString(KeyCart, stringObject);

            
        }
                
    }

}
