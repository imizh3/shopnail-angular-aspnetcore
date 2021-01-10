using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Khuyenmaict
    {
        public int Itemid { get; set; }
        public string Madonvi { get; set; }
        public string Machuongtrinh { get; set; }
        public string Masieuthiban { get; set; }
        public string Masieuthikm { get; set; }
        public string Mabohang { get; set; }
        public decimal? Soluongban { get; set; }
        public decimal? Soluongkm { get; set; }
        public string Makhohangban { get; set; }
        public string Makhohangkm { get; set; }
        public decimal? Soluongmaxinbin { get; set; }
        public decimal? Giatrikmmax { get; set; }
        public decimal? Giatrikmmin { get; set; }
        public decimal? Tilechietkhau { get; set; }
        public decimal? Tienchietkhau { get; set; }
        public string Manganhhang { get; set; }
        public string Manhomhang { get; set; }
        public string Manhacungcap { get; set; }

        public virtual Khuyenmai Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
