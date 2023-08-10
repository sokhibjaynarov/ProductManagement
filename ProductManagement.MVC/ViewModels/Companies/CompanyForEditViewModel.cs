using System;

namespace ProductManagement.MVC.ViewModels.Companies
{
    public class CompanyForEditViewModel
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string NameOfPlace { get; set; }

    }
}
