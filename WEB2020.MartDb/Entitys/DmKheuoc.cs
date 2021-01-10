using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class DmKheuoc
    {
        public string Makheuoc { get; set; }
        public string Madonvi { get; set; }
        public string Manganhang { get; set; }
        public string Noidung { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaybatdau { get; set; }
        public DateTime Ngayketthuc { get; set; }
        public decimal Sotien { get; set; }
        public decimal Tylelai { get; set; }
        public int Songay { get; set; }
    }
}
