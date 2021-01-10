using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Giaodichcktrathuong
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Mactktpk { get; set; }
        public string Manhomhang { get; set; }
        public string Manganh { get; set; }
        public decimal? Tileckthang { get; set; }
        public decimal? Tilecknam { get; set; }
        public decimal? Tienckthang { get; set; }
        public decimal? Tiencknam { get; set; }
        public int Loai { get; set; }
        public int Iskhachhang { get; set; }
        public string Masieuthi { get; set; }
    }
}
