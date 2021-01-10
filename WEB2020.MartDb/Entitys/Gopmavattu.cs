using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Gopmavattu
    {
        public int Id { get; set; }
        public string Madonvi { get; set; }
        public string Madutoan { get; set; }
        public string Masieuthi { get; set; }
        public string Masieuthigop { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Dongia { get; set; }
        public decimal? Dongia1 { get; set; }
        public decimal? Thanhtien { get; set; }
        public decimal? Thanhtien1 { get; set; }
        public int? Loai { get; set; }
    }
}
