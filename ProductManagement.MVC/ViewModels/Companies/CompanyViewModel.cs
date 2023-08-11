using System;
using System.ComponentModel;

namespace ProductManagement.MVC.ViewModels.Companies
{
    public class CompanyViewModel
    {
        [DisplayName("Kompaniya raqami")]
        public Guid CompanyId { get; set; }

        [DisplayName("Kompaniya nomi")]
        public string CompanyName { get; set; }

        [DisplayName("Qurilish joyi")]
        public string Address { get; set; }

        [DisplayName("INN")]
        public string INN { get; set; }

        [DisplayName("Kompaniya filiali")]
        public string NameOfPlace { get; set; }
    }
}
