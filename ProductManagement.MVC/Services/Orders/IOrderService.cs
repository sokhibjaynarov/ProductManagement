using System.Linq;
using System.Threading.Tasks;
using System;
using ProductManagement.MVC.Models;

namespace ProductManagement.MVC.Services.Orders
{
    public interface IOrderService
    {
        ValueTask<Order> AddOrderAsync(Order order);

        IQueryable<Order> RetrieveAllOrders();

        ValueTask<Order> RetrieveOrderByIdAsync(Guid orderId);

        ValueTask<Order> ModifyOrderAsync(Order order);

        ValueTask<Order> RemoveOrderByIdAsync(Guid orderId);
    }
}
