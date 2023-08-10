using Microsoft.Data.SqlClient;
using ProductManagement.MVC.Brokers.StorageBrokers;
using ProductManagement.MVC.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.MVC.Services.Companies
{
    public class CompanyService : ICompanyService
    {
        private readonly IStorageBroker storageBroker;

        public CompanyService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        private delegate ValueTask<Company> ReturningCompanyFunction();
        private delegate IQueryable<Company> ReturningCompaniesFunction();
        private async ValueTask<Company> TryCatch(ReturningCompanyFunction returningCompanyFunction)
        {
            try
            {
                return await returningCompanyFunction();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        private IQueryable<Company> TryCatch(ReturningCompaniesFunction returningCompaniesFunction)
        {
            try
            {
                return returningCompaniesFunction();
            }
            catch (SqlException sqlException)
            {
                throw new NotImplementedException();
            }
        }
        public ValueTask<Company> AddCompanyAsync(Company company) =>
            TryCatch(async () =>
            {
                return await this.storageBroker.InsertCompanyAsync(company);
            });


        public ValueTask<Company> ModifyCompanyAsync(Company company) =>
            TryCatch(async () =>
            {
                Company maybeCompany =
                    await this.storageBroker.SelectCompanyByIdAsync(company.CompanyId);
                return await storageBroker.UpdateCompanyAsync(company);
            });


        public ValueTask<Company> RemoveCompanyByIdAsync(Guid companyId) =>
            TryCatch(async () =>
            {
                Company maybeCompany =
                    await this.storageBroker.SelectCompanyByIdAsync(companyId);

                return await storageBroker.DeleteCompanyAsync(maybeCompany);
            });


        public IQueryable<Company> RetrieveAllCompanies() =>
            TryCatch(() =>
                 this.storageBroker.SelectAllCompanys());

        public ValueTask<Company> RetrieveCompanyByIdAsync(Guid companyId) =>
            TryCatch(async () =>
            {
                Company maybeCompany =
                    await storageBroker.SelectCompanyByIdAsync(companyId);
                return maybeCompany;
            });

    }
}
