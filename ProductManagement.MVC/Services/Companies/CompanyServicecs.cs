using System;
using System.Linq;
using System.Threading.Tasks;
using ProductManagement.MVC.Models;

namespace ProductManagement.MVC.Services.Companies
{
    public class CompanyServicecs : ICompanyService
    {
        public ValueTask<Company> AddCompanyAsync(Company Company)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Company> ModifyCompanyAsync(Company Company)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Company> RemoveCompanyByIdAsync(Guid CompanyId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Company> RetrieveAllCompanys()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Company> RetrieveCompanyByIdAsync(Guid CompanyId)
        {
            throw new NotImplementedException();
        }
    }
}
