using ProductManagement.MVC.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.MVC.ViewModels.Order
{
    public class OrderForEditStatusViewModel
    {
        public Guid OrderId { get; set; }

        [DisplayName("Kompaniya nomi")]
        [Required(ErrorMessage = "Kompaniya nomini kiriting!")]
        public string CompanyName { get; set; }

        [DisplayName("Obyekt nomi")]
        [Required(ErrorMessage = "Obyekt nomini kiriting!")]
        public string NameOfPlace { get; set; }

        [DisplayName("Status")]
        public OrderStatus Status { get; set; }

        [DisplayName("Ishni bajardim!")]
        public bool IsOrderCompleted { get; set; }

        [DisplayName("Mahsulot hajmi")]
        [Required(ErrorMessage = "Mahsulot hajmini kiriting!")]
        public decimal VolumeProduct { get; set; }

        [DisplayName("Bo'yi")]
        [Required(ErrorMessage = "Bo'yini kiriting!")]
        public int High { get; set; }

        [DisplayName("Eni")]
        [Required(ErrorMessage = "Enini kiriting!")]
        public int Width { get; set; }

        [DisplayName("Kompaniya nomi")]
        [Required(ErrorMessage = "Balandligini kiriting!")]
        public int Height { get; set; }

        [DisplayName("Izoh")]
        [Required(ErrorMessage = "Izohni kiriting!")]
        public string Comment { get; set; }

        [DisplayName("Yetkazish vaqti")]
        [Required(ErrorMessage = "Yetkazish vaqtini kiriting!")]
        public DateTime Deadline { get; set; }

        [DisplayName("Yaratilgan vaqti")]
        [Required(ErrorMessage = "Yaratilgan vaqtini kiriting!")]
        public DateTime CreateDate { get; set; }
    }
}
