using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace ProductManagement.MVC.ViewModels.Companies
{
    public class CompanyForEditViewModel
    {
        [DisplayName("Kompaniya raqami")]
        public Guid CompanyId { get; set; }

        [DisplayName("Kompaniya nomi")]
        public string CompanyName { get; set; }

        [DisplayName("Qurilish joyi")]
        [Required(ErrorMessage = "Qurilish manzilini kiritilishi shart")]
        public string Address { get; set; }

        [DisplayName("INN")]
        [Required(ErrorMessage = "Korxona yoki kompanya INN si kiritilishi shart")]
        public string INN { get; set; }

        [DisplayName("Kompaniya filiali")]
        public string NameOfPlace { get; set; }

    }
}
