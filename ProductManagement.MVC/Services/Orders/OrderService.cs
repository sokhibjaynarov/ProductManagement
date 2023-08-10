using Microsoft.Data.SqlClient;
using ProductManagement.MVC.Brokers.StorageBrokers;
using ProductManagement.MVC.Models;
using ProductManagement.MVC.Services.Orders;
using System;
using System.Linq;
using System.Threading.Tasks;

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
        private delegate IQueryable<Order> ReturningOrdersFunction();
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

        private IQueryable<Order> TryCatch(ReturningOrdersFunction returningOrdersFunction)
        {
            try
            {
                return returningOrdersFunction();
            }
            catch (SqlException sqlException)
            {
                throw new NotImplementedException();
            }
        }


        public ValueTask<Order> AddOrderAsync(Order order) =>


            TryCatch(async () =>
            {

                return await this.storageBroker.InsertOrderAsync(order);

            });


        public IQueryable<Order> RetrieveAllOrders() =>
            TryCatch(() => this.storageBroker.SelectAllOrders());


        public ValueTask<Order> ModifyOrderAsync(Order order) =>
            TryCatch(async () =>
            {
                Order maybeOrder =
                   await storageBroker.SelectOrderByIdAsync(order.OrderId);
                return await this.storageBroker.UpdateOrderAsync(order);
            });


        public ValueTask<Order> RemoveOrderByIdAsync(Guid orderId) =>
            TryCatch(async () =>
            {
                Order maybeOrder =
                    await storageBroker.SelectOrderByIdAsync(orderId);
                return await this.storageBroker.DeleteOrderAsync(maybeOrder);
            });

        public ValueTask<Order> RetrieveOrderByIdAsync(Guid orderId) =>

            TryCatch(async () =>
            {
                // Order maybeOrder =
                return await this.storageBroker.SelectOrderByIdAsync(orderId);

                // return maybeOrder; 
            });

    }
}
