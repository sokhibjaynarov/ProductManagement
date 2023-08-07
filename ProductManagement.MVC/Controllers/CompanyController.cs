using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProductManagement.MVC.Models;
using ProductManagement.MVC.Services.Companies;

namespace ProductManagement.MVC.Controllers
{
    public class CompanyController : Controller
    {

        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        //GET: Companies
        public IActionResult Index()
        {
            var company = companyService.RetrieveAllCompanies();
            return View(company);
        }

        //GET for edit Company
        public async Task<ActionResult> Edit(Guid id)
        {
            var company = await companyService.RetrieveCompanyByIdAsync(id);

            return View(company);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Company company)
        {
            var existCompany = await companyService.RetrieveCompanyByIdAsync(company.CompanyId);

            existCompany.CompanyName = company.CompanyName;
            existCompany.INN = company.INN;
            existCompany.Address = company.Address;
            existCompany.NameOfPlace = company.NameOfPlace;
            existCompany.CompanyId = company.CompanyId;

            await companyService.ModifyCompanyAsync(existCompany);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(Guid Id)
        {
            var company = await companyService.RetrieveCompanyByIdAsync(Id);

            return View(company);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Company company)

        {
            await companyService.AddCompanyAsync(company);

            ViewBag.Message = "Data Added Seccessfully";

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(Guid Id)
        {
           // var company = await companyService.RetrieveCompanyByIdAsync(Id);

            await companyService.RemoveCompanyByIdAsync(Id);

            ViewBag.Message = "Company Delete Successfully";
            return RedirectToAction("Index");
        }
    }
}
