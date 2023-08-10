using ProductManagement.MVC.Enums;
using System.Collections.Generic;
using System;

namespace ProductManagement.MVC.ViewModels.Order
{
    public class OrderForEditStatusViewModel
    {
        public Guid OrderId { get; set; }
        public string CompanyName { get; set; }
        public string NameOfPlace { get; set; }
        public OrderStatus Status { get; set; }
        public bool IsOrderCompleted { get; set; }
        public decimal VolumeProduct { get; set; }
        public int High { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Comment { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
