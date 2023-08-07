using Microsoft.AspNetCore.Mvc;
using ProductManagement.MVC.Services.Companies;
using ProductManagement.MVC.Services.Orders;

namespace ProductManagement.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly ICompanyService companyService;

        public OrderController(
            IOrderService orderService, 
            ICompanyService companyService)
        {
            this.orderService = orderService;
            this.companyService = companyService;
        }

        public IActionResult Index()
        {
            var orders = orderService.RetrieveAllOrders();
            return View(orders);
        }
    }
}
