﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.MVC.Models;
using ProductManagement.MVC.Services.Companies;
using ProductManagement.MVC.ViewModels.Companies;
using ProductManagement.MVC.ViewModels.Order;

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
        [Authorize(Roles = "SuperAdmin, Admin, Manager, Worker")]
        public IActionResult Index()
        {

            var companies = companyService.RetrieveAllCompanies().ToList();
            var companiesViewModel = new List<CompanyViewModel>();

            foreach (Company company in companies)
            {
                companiesViewModel.Add(new CompanyViewModel()
                {
                    CompanyId = company.CompanyId,
                    CompanyName = company.CompanyName,
                    Address = company.Address,
                    INN = company.INN,
                    NameOfPlace = company.NameOfPlace,
                });
            }


            return View(companiesViewModel);
        }

        //GET for edit Company
        [Authorize(Roles = "SuperAdmin, Manager")]
        public async Task<ActionResult> Edit(Guid id)
        {
            var company = await companyService.RetrieveCompanyByIdAsync(id);
            var companies = companyService.RetrieveAllCompanies().ToList();

            var companyForEditViewModel = new CompanyForEditViewModel()
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                Address = company.Address,
                INN = company.INN,
                NameOfPlace = company.NameOfPlace,
            };
            return View(companyForEditViewModel);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Manager")]
        public async Task<ActionResult> Edit(Company company)
        {
            var existCompany = await companyService.RetrieveCompanyByIdAsync(company.CompanyId);

           /* existCompany.CompanyName = company.CompanyName;
            existCompany.INN = company.INN;
            existCompany.Address = company.Address;
            existCompany.NameOfPlace = company.NameOfPlace;
            existCompany.CompanyId = company.CompanyId;*/ 

            await companyService.ModifyCompanyAsync(existCompany);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "SuperAdmin, Admin, Manager, Worker")]
        public async Task<ActionResult> Details(Guid Id)
        {
            var company = await companyService.RetrieveCompanyByIdAsync(Id);

            var companyViewModel = new CompanyViewModel()
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                Address = company.Address,
                INN = company.INN,
                NameOfPlace = company.NameOfPlace,
            };

            return View(companyViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Manager")]
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Manager")]
        public async Task<ActionResult> Create(CompanyForCreateViewModel companyForCreateViewModel)

        {
           var company = new Company()
           {
               CompanyName = companyForCreateViewModel.CompanyName,
               Address = companyForCreateViewModel.Address,
               INN= companyForCreateViewModel.INN,
               NameOfPlace= companyForCreateViewModel.NameOfPlace,
           };

            await companyService.AddCompanyAsync(company);

            

            ViewBag.Message = "Data Added Seccessfully";

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "SuperAdmin")]
        public async Task<ActionResult> Delete(Guid Id)
        {
            // var company = await companyService.RetrieveCompanyByIdAsync(Id);

            await companyService.RemoveCompanyByIdAsync(Id);

            ViewBag.Message = "Company Delete Successfully";
            return RedirectToAction("Index");
        }
    }
}
