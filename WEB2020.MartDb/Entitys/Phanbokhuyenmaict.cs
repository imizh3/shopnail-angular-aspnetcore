using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Phanbokhuyenmaict
    {
        public string Itemid { get; set; }
        public string Machuongtrinh { get; set; }
        public string Madonvi { get; set; }
        public string Doituongapdung { get; set; }
        public decimal? Soluongduocphanbo { get; set; }
        public decimal? Tienduocphanbo { get; set; }
    }
}
