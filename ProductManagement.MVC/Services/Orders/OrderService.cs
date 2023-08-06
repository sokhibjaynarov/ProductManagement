using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using ProductManagement.MVC.Brokers.StorageBrokers;
using ProductManagement.MVC.Models;
using ProductManagement.MVC.Services.Orders;

namespace ProductManagement.MVC.Services.OrderService
{
    public class OrderService : IOrderService
    {

        private readonly IStorageBroker storageBroker;

        public OrderService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        private delegate ValueTask<Order> ReturningOrderFunction();

        private async ValueTask<Order> TryCatch(ReturningOrderFunction returningOrderFunction)
        {
            try
            {
                return await returningOrderFunction();
            }
            catch (Exception ex) 
            {
                throw new NotImplementedException();        
                    
            }
        }

        public ValueTask<Order> AddOrderAsync(Order order) =>
        

            TryCatch(async () =>
            {

                return await this.storageBroker.InsertOrderAsync(order);

            });

            
        

        public ValueTask<Order> ModifyOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Order> RemoveOrderByIdAsync(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> RetrieveAllOrders()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Order> RetrieveOrderByIdAsync(Guid orderId)
        {
            throw new NotImplementedException();
        }
    }
}
