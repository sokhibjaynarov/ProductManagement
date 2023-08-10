using ProductManagement.MVC.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.MVC.Services.Companies
{
    public interface ICompanyService
    {
        ValueTask<Company> AddCompanyAsync(Company Company);

        IQueryable<Company> RetrieveAllCompanies();

        ValueTask<Company> RetrieveCompanyByIdAsync(Guid CompanyId);

        ValueTask<Company> ModifyCompanyAsync(Company Company);

        ValueTask<Company> RemoveCompanyByIdAsync(Guid CompanyId);
    }
}
