﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.MVC.ViewModels.Order
{
    public class OrderForCreateViewModel
    {
        [DisplayName("Mahsulot hajmi")]
        [Required(ErrorMessage = "Mahsulot hajmini kiriting!")]
        public decimal VolumeProduct { get; set; }

        [DisplayName("Bo'yi")]
        [Required(ErrorMessage = "Bo'yini kiriting!")]
        public int High { get; set; }

        [DisplayName("Eni")]
        [Required(ErrorMessage = "Enini kiriting!")]
        public int Width { get; set; }

        [DisplayName("Balandligi")]
        [Required(ErrorMessage = "Balandligini kiriting!")]
        public int Height { get; set; }

        [DisplayName("Izoh")]
        public string Comment { get; set; }

        [DisplayName("Yetkazish vaqti")]
        [Required(ErrorMessage = "Yetkazish vaqtini kiriting!")]
        public DateTime Deadline { get; set; }

        public List<CompanyListViewModel> Companies { get; set; }

        public Guid CompanyId { get; set; }

        public string CompanyName { get; set; }
    }
}
