using Microsoft.AspNetCore.Identity;
using ProductManagement.MVC.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.MVC.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new ApplicationRole { Name = Enums.Roles.SuperAdmin.ToString() });
            await roleManager.CreateAsync(new ApplicationRole { Name = Enums.Roles.Admin.ToString() });
            await roleManager.CreateAsync(new ApplicationRole { Name = Enums.Roles.Manager.ToString() });
            await roleManager.CreateAsync(new ApplicationRole { Name = Enums.Roles.Worker.ToString() });
        }
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            //Seed Users
            var superAdmin = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "superadmin@gmail.com",
                FirstName = "Sokhib",
                LastName = "Jaynarov",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var admin = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@gmail.com",
                FirstName = "Khusan",
                LastName = "Rakhmatullayev",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var manager = new ApplicationUser
            {
                UserName = "manager",
                Email = "manager@gmail.com",
                FirstName = "Sardor",
                LastName = "Tuymurodov",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var worker = new ApplicationUser
            {
                UserName = "worker",
                Email = "worker@gmail.com",
                FirstName = "Abduvali",
                LastName = "Abdujalilov",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != superAdmin.Id))
            {
                var user = await userManager.FindByEmailAsync(superAdmin.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(superAdmin, "123Pa$$word.");
                    await userManager.AddToRoleAsync(superAdmin, Enums.Roles.SuperAdmin.ToString());
                }
            }

            if (userManager.Users.All(u => u.Id != admin.Id))
            {
                var user = await userManager.FindByEmailAsync(admin.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(admin, "123Pa$$word.");
                    await userManager.AddToRoleAsync(admin, Enums.Roles.Admin.ToString());
                }
            }

            if (userManager.Users.All(u => u.Id != manager.Id))
            {
                var user = await userManager.FindByEmailAsync(manager.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(manager, "123Pa$$word.");
                    await userManager.AddToRoleAsync(manager, Enums.Roles.Manager.ToString());
                }
            }

            if (userManager.Users.All(u => u.Id != worker.Id))
            {
                var user = await userManager.FindByEmailAsync(worker.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(worker, "123Pa$$word.");
                    await userManager.AddToRoleAsync(worker, Enums.Roles.Worker.ToString());
                }
            }
        }
    }
}
