using System.Linq;
using System.Threading.Tasks;
using System;
using ProductManagement.MVC.Models;

namespace ProductManagement.MVC.Brokers.StorageBrokers
{
    public partial interface IStorageBroker
    {
        ValueTask<Order> InsertOrderAsync(Order order);
        IQueryable<Order> SelectAllOrders();
        ValueTask<Order> SelectOrderByIdAsync(Guid orderId);
        ValueTask<Order> UpdateOrderAsync(Order order);
        ValueTask<Order> DeleteOrderAsync(Order order);
    }
}
