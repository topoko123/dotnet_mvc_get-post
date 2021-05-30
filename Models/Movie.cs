using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc.Models
{
    public class Movie
    {
        [Display(Name = "รหัสภาพยนต์")]
        public int Id {get; set; }

        [Display(Name = "ชื่อเรื่อง")]
        public string Title {get; set; }

        [Display(Name = "วันที่ออกอากาศ")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "ประเภท")]
        public string Genre { get; set; }

        [Display(Name = "ราคา")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }
    }
}