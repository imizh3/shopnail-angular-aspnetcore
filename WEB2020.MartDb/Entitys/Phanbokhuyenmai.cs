using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Phanbokhuyenmai
    {
        public string Machuongtrinh { get; set; }
        public string Madonvi { get; set; }
        public string Loaiphanbo { get; set; }
        public int? Kieuphanbo { get; set; }
        public decimal? Tonggiatriphanbo { get; set; }
        public decimal? Tongsoluongphanbo { get; set; }
    }
}
