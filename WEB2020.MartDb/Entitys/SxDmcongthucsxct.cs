using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxDmcongthucsxct
    {
        public string Mactpk { get; set; }
        public string Masieuthi { get; set; }
        public decimal Soluong { get; set; }
        public string Madonvi { get; set; }
        public decimal? Tilehaohut { get; set; }
        public string Makhachhang { get; set; }
        public string Masieuthithaythe { get; set; }
        public string Makhachhangthaythe { get; set; }
        public int? Sort { get; set; }
        public string Ghichu { get; set; }
        public decimal? Tiledat { get; set; }
        public decimal? Heso { get; set; }

        public virtual SxDmcongthucsx Ma { get; set; }
    }
}
