using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Khachhangtt
    {
        public string Mact { get; set; }
        public string Madonvi { get; set; }
        public string Tenct { get; set; }
        public bool? Reset { get; set; }
        public decimal? Diemmin { get; set; }
        public decimal? Diemmax { get; set; }
        public decimal? Doanhsomin { get; set; }
        public decimal? Doanhsomax { get; set; }
    }
}
