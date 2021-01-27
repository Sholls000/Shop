using Microsoft.AspNetCore.Mvc;
using Shop.Application.Cart;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private GetCart _getCart;

        public CartViewComponent(GetCart getCart)
        {
            _getCart = getCart;
        }

        public IViewComponentResult Invoke(string view = "Default")
        {
            if(view == "small")
            {
                //Getting Total value of cart Items
                var totalValue = _getCart.Do().Sum(x => x.RealValue * x.Qty);
                return View(view, $"₦{totalValue}");
            }

            return View(view, _getCart.Do());
        }
    }

}
