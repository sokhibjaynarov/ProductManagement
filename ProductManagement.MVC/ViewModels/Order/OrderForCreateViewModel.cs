using System;
using System.Collections.Generic;

namespace ProductManagement.MVC.ViewModels.Order
{
    public class OrderForCreateViewModel
    {
        public string TypeOfProduct { get; set; }
        public int High { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Comment { get; set; }
        public DateTime Deadline { get; set; }
        public List<CompanyListViewModel> Companies { get; set; }
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
