using Microsoft.AspNetCore.Mvc;
using ProductManagement.MVC.Brokers.UserManagement;
using ProductManagement.MVC.Models;
using System;
using System.Threading.Tasks;

namespace ProductManagement.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManagementBroker userManagementBroker;

        public UserController(IUserManagementBroker userManagementBroker)
        {
            this.userManagementBroker = userManagementBroker;
        }

        // GET: User
        public IActionResult Index()
        {
            var users = userManagementBroker.SelectAllUsers();
            return View(users);
        }

        // GET: For edit user
        public async Task<ActionResult> Edit(Guid Id)
        {
            var user = await userManagementBroker.SelectUserByIdAsync(Id);

            return View(user);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ApplicationUser user)
        {
            var existUser = await userManagementBroker.SelectUserByIdAsync(user.Id);

            existUser.FirstName = user.FirstName;
            existUser.LastName = user.LastName;

            await userManagementBroker.UpdateUserAsync(existUser);

            return RedirectToAction("Index");
        }

        // GET: For details user
        public async Task<ActionResult> Details(Guid Id)
        {
            var user = await userManagementBroker.SelectUserByIdAsync(Id);

            return View(user);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(ApplicationUser user)
        {
            await userManagementBroker.InsertUserAsync(user, "!MyNewPassword)1");
            ViewBag.Message = "Data Insert Successfully";
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(Guid Id)
        {
            var user = await userManagementBroker.SelectUserByIdAsync(Id);

            await userManagementBroker.DeleteUserAsync(user);
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
        }
    }
}
