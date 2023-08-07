using ProductManagement.MVC.Enums;
using System;

namespace ProductManagement.MVC.ViewModels.Order
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string CompanyName { get; set; }
        public string NameOfPlace { get; set; }
        public OrderStatus Status { get; set; }
        public string TypeOfProduct { get; set; }
        public int High { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Comment { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
