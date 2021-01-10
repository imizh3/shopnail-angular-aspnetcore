using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Khohanggia
    {
        public string Madonvi { get; set; }
        public string Makhohang { get; set; }
        public string Maloaigia { get; set; }
        public string Maapdung { get; set; }
        public decimal Giamuacovat { get; set; }
        public decimal? Giamuachuavat { get; set; }
        public decimal? Giabanlecovat { get; set; }
        public decimal? Giabanlechuavat { get; set; }
        public decimal? Giabanbuoncovat { get; set; }
        public decimal? Giabanbuonchuavat { get; set; }
        public decimal? Tyleck { get; set; }
        public int Trangthaisudung { get; set; }
        public DateTime Ngayapdung { get; set; }
        public decimal? Tilelaile { get; set; }
        public decimal? Tilelaibuon { get; set; }
        public string Makhachhang { get; set; }
    }
}
