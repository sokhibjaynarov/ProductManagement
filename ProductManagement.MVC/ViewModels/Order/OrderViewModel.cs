using ProductManagement.MVC.Enums;
using System;
using System.ComponentModel;

namespace ProductManagement.MVC.ViewModels.Order
{
    public class OrderViewModel
    {
        [DisplayName("Buyurtma raqami")]
        public Guid OrderId { get; set; }

        [DisplayName("Kompaniya nomi")]
        public string CompanyName { get; set; }

        [DisplayName("Obyekt nomi")]
        public string NameOfPlace { get; set; }

        [DisplayName("Status")]
        public OrderStatus Status { get; set; }

        /* [DisplayName("Mahsulot turi")]
         public string TypeOfProduct { get; set; }*/

        [DisplayName("Mahsulot hajmi")]
        public decimal VolumeProduct { get; set; }

        [DisplayName("Bo'yi")]
        public int High { get; set; }

        [DisplayName("Eni")]
        public int Width { get; set; }

        [DisplayName("Balandligi")]
        public int Height { get; set; }

        [DisplayName("Izoh")]
        public string Comment { get; set; }

        [DisplayName("Yetkazish vaqti")]
        public DateTime Deadline { get; set; }

        [DisplayName("Yaratilgan vaqti")]
        public DateTime CreateDate { get; set; }
    }
}
