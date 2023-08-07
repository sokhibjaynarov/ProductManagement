using Microsoft.AspNetCore.Mvc;
using ProductManagement.MVC.Brokers.UserManagement;
using ProductManagement.MVC.Services.Companies;
using ProductManagement.MVC.Services.Orders;
using System.Threading.Tasks;
using System;
using ProductManagement.MVC.Models;

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

        // GET: Orders 
        public IActionResult Index()
        {
            var orders = orderService.RetrieveAllOrders();
            return View(orders);
        }

        // GET: For details order
        public async Task<ActionResult> Details(Guid Id)
        {
            var order = await orderService.RetrieveOrderByIdAsync(Id);

            return View(order);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Order order)
        {
            await orderService.AddOrderAsync(order);
            ViewBag.Message = "Data Insert Successfully";
            return RedirectToAction("Index");
        }

        // GET: For edit user
        public async Task<ActionResult> Edit(Guid Id)
        {
            var order = await orderService.RetrieveOrderByIdAsync(Id);

            return View(order);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Order order)
        {
            var existOrder = await orderService.RetrieveOrderByIdAsync(order.OrderId);


            await orderService.ModifyOrderAsync(existOrder);

            return RedirectToAction("Index");
        }
    }
}
