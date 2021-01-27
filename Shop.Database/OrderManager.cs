using Microsoft.EntityFrameworkCore;
using Shop.Domain.Enums;
using Shop.Domain.Infrastructure;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Database
{
    public class OrderManager : IOrderManager
    {
        private readonly ApplicationDbContext _ctx;

        public OrderManager(ApplicationDbContext ctx)
        {
            _ctx = ctx; 
        }


        public bool OrderReferenceExists(string reference)
        {
            return _ctx.Orders.Any(x => x.OrderRef == reference);
        }

        public IEnumerable<TResult> GetOrdersByStatus<TResult>(OrderStatus status, Func<Order, TResult> selector)
        {
            return _ctx.Orders
               .Where(x => x.Status == status)
               .Select(selector)
               .ToList();
        }
        
        //method to avoid repetition in return statement(interface implementation)
        //for GetOrderById  and GetOrderByReference.......((check boiler plate for While using Tresult
        private TResult GetOrder<TResult>(
            Func<Order, bool> condition,
            Func<Order, TResult> selector)
        {
            return _ctx.Orders
               .Where(x => condition(x))
               .Include(x => x.OrderStocks)
                  .ThenInclude(x => x.Stock)
                       .ThenInclude(x => x.Product)
               .Select(selector)
               .FirstOrDefault();

        }

        public TResult GetOrderById<TResult>(int id, Func<Order, TResult> selector)
        {
            return GetOrder(order => order.Id == id, selector);
            // Alternative to the private TResult GetOrder
            //return _ctx.Orders
            //   .Where(x => x.Id == id)
            //   .Include(x => x.OrderStocks)
            //      .ThenInclude(x => x.Stock)
            //           .ThenInclude(x => x.Product)
            //   .Select(selector)
            //   .FirstOrDefault();
        }

        public TResult GetOrderByReference<TResult>(string reference,
            Func<Order, TResult> selector)
        {
            return GetOrder(x => x.OrderRef == reference, selector);
            // Alternative to the private TResult GetOrder
            //return _ctx.Orders
            //   .Where(x => x.OrderRef == reference)
            //   .Include(x => x.OrderStocks)
            //      .ThenInclude(x => x.Stock)
            //           .ThenInclude(x => x.Product)
            //   .Select(selector)
            //   .FirstOrDefault();


        }

        public Task<int> CreateOrder(Order order)
        {
            //assigning the data received in order to Orders -- Saving to db
            _ctx.Orders.Add(order);

            return  _ctx.SaveChangesAsync();
        }

        public Task<int> AdvanceOrder(int id)
        {
            _ctx.Orders.FirstOrDefault(x => x.Id == id).Status++;

            return  _ctx.SaveChangesAsync();
        }
    }
}
