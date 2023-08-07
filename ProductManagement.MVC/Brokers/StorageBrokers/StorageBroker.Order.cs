using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagement.MVC.Models;

namespace ProductManagement.MVC.Brokers.StorageBrokers
{
    public partial class StorageBroker
    {
        public DbSet<Order> Orders { get; set; }
        public async ValueTask<Order> InsertOrderAsync(Order order) =>
            await InsertAsync(order);

        public IQueryable<Order> SelectAllOrders() =>
            SelectAll<Order>();

        public async ValueTask<Order> SelectOrderByIdAsync(Guid orderId) =>
            await SelectAsync<Order>(orderId);

        public async ValueTask<Order> UpdateOrderAsync(Order order) =>
            await UpdateAsync<Order>(order);

        public async ValueTask<Order> DeleteOrderAsync(Order order) =>
            await DeleteAsync<Order>(order);
    }
}
