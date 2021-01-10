using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dutoanct
    {
        public string Madonvi { get; set; }
        public string Madutoan { get; set; }
        public string Mahangmuc { get; set; }
        public string Masieuthi { get; set; }
        public string Tendaydu { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Dongia { get; set; }
        public decimal? Dongia1 { get; set; }
        public decimal? Dongia2 { get; set; }
        public decimal? Thanhtien { get; set; }
        public decimal? Thanhtien1 { get; set; }
        public decimal? Thanhtien2 { get; set; }
        public decimal? Hesodieuchinh { get; set; }
        public decimal? Hesodieuchinh1 { get; set; }
        public decimal? Hesodieuchinh2 { get; set; }
        public string Cancu { get; set; }
        public string Cancu1 { get; set; }
        public string Cancu2 { get; set; }
        public string Ghichu { get; set; }
        public int? Sort { get; set; }

        public virtual Dutoan Mad { get; set; }
    }
}
