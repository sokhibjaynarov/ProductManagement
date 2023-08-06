using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagement.MVC.Models;

namespace ProductManagement.MVC.Brokers.StorageBrokers
{
    public partial class StorageBroker
    {
        public DbSet<Company> Companies { get; set; }
        public async ValueTask<Company> InsertCompanyAsync(Company company) =>
            await InsertAsync(company);

        public IQueryable<Company> SelectAllCompanys() =>
            SelectAll<Company>();

        public async ValueTask<Company> SelectCompanyByIdAsync(Guid companyId) =>
            await SelectAsync<Company>(companyId);

        public async ValueTask<Company> UpdateCompanyAsync(Company company) =>
            await UpdateAsync<Company>(company);

        public async ValueTask<Company> DeleteCompanyAsync(Company Company) =>
            await DeleteAsync<Company>(Company);
    }
}
