using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.MVC.Models
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string NameOfPlace { get; set; }

    }
}
