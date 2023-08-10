using ProductManagement.MVC.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

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
