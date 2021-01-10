using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Giaodichgiaonhanct
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public string Manganh { get; set; }
        public string Makhachhang { get; set; }
        public string Manhomhang { get; set; }
        public decimal? Soluongnhap { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Dongia { get; set; }
        public int? Sort { get; set; }

        public virtual Giaodichgiaonhan Ma { get; set; }
    }
}
