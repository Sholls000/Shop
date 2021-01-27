using Microsoft.EntityFrameworkCore;
using Shop.Database;
using Shop.Domain.Infrastructure;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Database
{
   
        public class StockManager : IStockManager
        {
            private ApplicationDbContext _ctx;

            public StockManager(ApplicationDbContext ctx)
            {
                _ctx = ctx;
            }

            public bool EnoughStock(int stockId, int qty)
            {
                //Checking if the available stock is more than or equal to requested quantity
                return _ctx.Stock.FirstOrDefault(x => x.Id == stockId).Qty >= qty;
                }

            public Stock GetStockWithProduct(int stockId)
            {
                return _ctx.Stock
                .Include(x => x.Product)
                .FirstOrDefault(x => x.Id == stockId); 
            }

            public Task RemoveStockFromHold(int stockId, int qty, string sessionId)
            {
                //returning stockOnHold
                var stockOnHold = _ctx.StockOnHolds
                    .FirstOrDefault(x => x.StockId == stockId
                          && x.SessionId == sessionId);
                var stock = _ctx.Stock.FirstOrDefault(x => x.Id == stockId);

                stock.Qty += qty;
                stockOnHold.Qty -= qty;

                if (stockOnHold.Qty <= 0)
                {
                    _ctx.Remove(stockOnHold);
                }
                return _ctx.SaveChangesAsync();
            }

        public Task RemoveStockFromHold(string sessionId)
        {
            var stockOnHold = _ctx.StockOnHolds
                .Where(x => x.SessionId == sessionId)
                  .ToList();

            _ctx.StockOnHolds.RemoveRange(stockOnHold);  //removing stocks in session

            return _ctx.SaveChangesAsync();
        }

       
        Task IStockManager.PutStockOnHold(int stockId, int qty, string sessionId)
            {
                //database responsibility to update stock
                _ctx.Stock.FirstOrDefault(x => x.Id == stockId).Qty -= qty;

                //setting the held stockOnHold to Sessions.
                var stockOnHold = _ctx.StockOnHolds
                    .Where(x => x.SessionId == sessionId)
                    .ToList();

                if (stockOnHold.Any(x => x.StockId == stockId))
                {
                    stockOnHold.Find(x => x.StockId == stockId).Qty += qty;
                }
                else
                {

                    _ctx.StockOnHolds.Add(new StockOnHold
                    {
                        StockId = stockId,
                        SessionId = sessionId,
                        Qty = qty,
                        ExpiryDate = DateTime.Now.AddMinutes(20)
                    });
                }
                //Setting expiry time for the stockOnHold registered in Sessions
                foreach (var stock in stockOnHold)
                {
                    stock.ExpiryDate = DateTime.Now.AddMinutes(20);
                }

                return _ctx.SaveChangesAsync();
            }
        public Task RetrieveExpiredStockOnHold()
        {
            //Checking StocksOnHold
            var stocksOnHold = _ctx.StockOnHolds.Where(x => x.ExpiryDate < DateTime.Now).ToList();

            if (stocksOnHold.Count > 0)
            {
                var stockToReturn = _ctx.Stock.Where(x => stocksOnHold.Any(y => y.StockId == x.Id)).ToList();


                //returning stockOnHold to available stock
                foreach (var stock in stockToReturn)
                {
                    stock.Qty = stock.Qty + stocksOnHold.FirstOrDefault(x => x.StockId == stock.Id).Qty;
                }
                _ctx.StockOnHolds.RemoveRange(stocksOnHold);

                return _ctx.SaveChangesAsync();
            }
            return Task.CompletedTask;
        }

        public Task<int> CreateStock(Stock stock)
        {
            _ctx.Stock.Add(stock);

            return _ctx.SaveChangesAsync();
        }

        public Task<int> DeleteStock(int id)
        {
            //LINQ query to remove selected stock frm db

            var stock = _ctx.Stock.FirstOrDefault(x => x.Id == id);

            _ctx.Stock.Remove(stock);

            return _ctx.SaveChangesAsync();
        }

        public Task<int> UpdateStockRange(List<Stock> stockList)
        {
            _ctx.Stock.UpdateRange(stockList);

            return _ctx.SaveChangesAsync();

        }
    }
}
