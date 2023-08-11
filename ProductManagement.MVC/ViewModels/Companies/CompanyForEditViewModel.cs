using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.MVC.ViewModels.Companies
{
    public class CompanyForEditViewModel
    {
        [Required]
        public Guid CompanyId { get; set; }

        [DisplayName("Kompaniya nomi")]
        [Required(ErrorMessage = "Kompaniya nomini kiriting!")]
        public string CompanyName { get; set; }

        [DisplayName("Manzil")]
        [Required(ErrorMessage = "Manzilni kiriting!")]
        public string Address { get; set; }

        [DisplayName("INN")]
        [Required(ErrorMessage = "INNini kiriting!")]
        public string INN { get; set; }

        [DisplayName("Obyekt nomi")]
        [Required(ErrorMessage = "Obyekt nomini kiriting!")]
        public string NameOfPlace { get; set; }

    }
}
