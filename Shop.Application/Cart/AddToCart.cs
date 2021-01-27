using Shop.Domain.Infrastructure;
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.Cart
{
    [Service]
    public class AddToCart
    {
        private ISessionManager _sessionManager;
        private IStockManager _stockManager;

        public AddToCart(ISessionManager sessionManager, IStockManager stockManager)
        {
            _sessionManager = sessionManager;
            _stockManager = stockManager;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
           //service responsibility - checking if there is stock available using Db to check stock
            if(!_stockManager.EnoughStock(request.StockId, request.Qty))
            {
                return false;
            }
                                         

            await _stockManager
                .PutStockOnHold(request.StockId, request.Qty, _sessionManager.GetId());

            //adding cartProduct(cart content) to sessions
            var stock = _stockManager.GetStockWithProduct(request.StockId); 

            var cartProduct = new CartProduct()
            {
                ProductId = stock.ProductId,
                StockId = stock.Id,
                Qty = request.Qty,
                ProductName = stock.Product.Name,
                Value = stock.Product.Value,
            };

            //referencing the sessionManager interface in AddToCart, then adding the cartProduc to Sessionss
            _sessionManager.AddProduct(cartProduct);
               

            return true;
        }
    }
}
