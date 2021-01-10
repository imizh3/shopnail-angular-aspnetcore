using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Kiemkect
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Manganh { get; set; }
        public string Manhomhang { get; set; }
        public string Makehang { get; set; }
        public string Masieuthi { get; set; }
        public decimal? Soluongtonmay { get; set; }
        public decimal? Soluongkiemke { get; set; }
        public decimal? Soluongchenhlech { get; set; }
        public decimal? Tientonmay { get; set; }
        public decimal? Tienkiemke { get; set; }
        public decimal? Tienchenhlech { get; set; }
        public decimal? Giavon { get; set; }
        public decimal? Soluongnhap { get; set; }
        public decimal? Soluongxuat { get; set; }

        public virtual Kiemke Ma { get; set; }
        public virtual Nhomhang Ma1 { get; set; }
        public virtual Mathang Ma2 { get; set; }
        public virtual Nganhhang MaNavigation { get; set; }
    }
}
