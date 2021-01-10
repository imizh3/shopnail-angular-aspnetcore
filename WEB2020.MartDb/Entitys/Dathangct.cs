using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dathangct
    {
        public string Magiaodichpk { get; set; }
        public string Masieuthi { get; set; }
        public string Madonvi { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Dongia { get; set; }
        public decimal? Tienhang { get; set; }
        public decimal? Tienvat { get; set; }
        public decimal? Thanhtien { get; set; }
        public decimal? Giabanlecovat { get; set; }
        public decimal? Giabanbuoncovat { get; set; }
        public decimal? Soluongthung { get; set; }
        public decimal? Toncuoikysl { get; set; }
        public decimal? Toncuoikygt { get; set; }
        public decimal? Tondaukysl { get; set; }
        public decimal? Tondaukygt { get; set; }
        public decimal? Nhaptksl { get; set; }
        public decimal? Nhaptkgt { get; set; }
        public decimal? Xuattksl { get; set; }
        public decimal? Xuattkgt { get; set; }
        public decimal? Soluongmax { get; set; }
        public decimal? Soluongmin { get; set; }
        public string Mavat { get; set; }
        public int? Sort { get; set; }
        public decimal? Giathungchuavat { get; set; }
        public string Ghichu { get; set; }

        public virtual Dathang Ma { get; set; }
        public virtual Mathang MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
