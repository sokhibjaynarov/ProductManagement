using ProductManagement.MVC.Models;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ProductManagement.MVC.Services.Companies
{
    public interface ICompanyService
    {
        ValueTask<Company> AddCompanyAsync(Company Company);

        IQueryable<Company> RetrieveAllCompanys();

        ValueTask<Company> RetrieveCompanyByIdAsync(Guid CompanyId);

        ValueTask<Company> ModifyCompanyAsync(Company Company);

        ValueTask<Company> RemoveCompanyByIdAsync(Guid CompanyId);
    }
}
