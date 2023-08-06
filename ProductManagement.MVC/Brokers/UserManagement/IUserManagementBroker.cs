using ProductManagement.MVC.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.MVC.Brokers.UserManagement
{
    public interface IUserManagementBroker
    {
        ValueTask<ApplicationUser> InsertUserAsync(ApplicationUser user, string password);
        IQueryable<ApplicationUser> SelectAllUsers();
        ValueTask<ApplicationUser> SelectUserByIdAsync(Guid userId);
        ValueTask<ApplicationUser> UpdateUserAsync(ApplicationUser user);
        ValueTask<ApplicationUser> DeleteUserAsync(ApplicationUser user);
    }
}
