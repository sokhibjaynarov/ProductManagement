using ProductManagement.MVC.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.MVC.Brokers.StorageBrokers
{
    public partial interface IStorageBroker
    {
        ValueTask<Company> InsertCompanyAsync(Company company);
        IQueryable<Company> SelectAllCompanys();
        ValueTask<Company> SelectCompanyByIdAsync(Guid companyId);
        ValueTask<Company> UpdateCompanyAsync(Company company);
        ValueTask<Company> DeleteCompanyAsync(Company company);
    }
}
