using Microsoft.AspNetCore.Mvc;
using ProductManagement.MVC.Brokers.UserManagement;
using ProductManagement.MVC.Services.Companies;
using ProductManagement.MVC.Services.Orders;
using System.Threading.Tasks;
using System;
using ProductManagement.MVC.Models;
using ProductManagement.MVC.ViewModels.Order;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

            var company = await companyService.RetrieveCompanyByIdAsync(order.CompanyId);

            var orderViewModel = new OrderViewModel()
            {
                OrderId = order.OrderId,
                TypeOfProduct = order.TypeOfProduct,
                Height = order.Height,
                High = order.High,
                Width = order.Width,
                Status = order.Status,
                NameOfPlace = company.NameOfPlace,
                CompanyName = company.CompanyName,
                CreateDate = order.CreateDate,
                Deadline = order.Deadline,
                Comment = order.Comment,
            };

            return View(orderViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var companies = companyService.RetrieveAllCompanies().ToList();
            var viewModel = new OrderForCreateViewModel()
            {
                Companies = companies.Select(company => new CompanyListViewModel { CompanyName = company.CompanyName, CompanyId = company.CompanyId }).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(OrderForCreateViewModel viewModel)
        {
            var order = new Order()
            {
                TypeOfProduct = viewModel.TypeOfProduct,
                Height = viewModel.Height,
                High = viewModel.High,
                Width = viewModel.Width,
                Status = Enums.OrderStatus.Ordered,
                CreateDate = DateTime.UtcNow,
                Deadline = viewModel.Deadline,
                Comment = viewModel.Comment,
                CompanyId = viewModel.CompanyId,
            };

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
