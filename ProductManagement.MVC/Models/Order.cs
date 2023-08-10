using ProductManagement.MVC.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.MVC.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }

        public OrderStatus Status { get; set; }

        //  public string TypeOfProduct { get; set; }

        public decimal VolumeProduct { get; set; }

        public int High { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Comment { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid CompanyId { get; set; }

        public Guid WorkerId { get; set; }
    }
}
