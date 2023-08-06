using System.Linq;
using System;
using System.Threading.Tasks;
using ProductManagement.MVC.Models;

namespace ProductManagement.MVC.Brokers.StorageBrokers
{
    public partial class StorageBroker
    {
        public async ValueTask<Order> InsertOrderAsync(Order order) =>
            await InsertAsync(order);

        public IQueryable<Order> SelectAllOrders() =>
            SelectAll<Order>();

        public async ValueTask<Order> SelectOrderByIdAsync(Guid o
            rderId) =>
            await SelectAsync<Order>(OrderId);

        public async ValueTask<Order> UpdateOrderAsync(Order order) =>
            await UpdateAsync<Order>(order);

        public async ValueTask<Order> DeleteOrderAsync(Order order) =>
            await DeleteAsync<Order>(order);
    }
}
