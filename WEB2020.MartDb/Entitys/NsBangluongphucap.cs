using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBangluongphucap
    {
        public string Mabangluong { get; set; }
        public string Manhanvien { get; set; }
        public string Maphucap { get; set; }
        public decimal? Sotien { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Madonvi { get; set; }

        public virtual NsBangluong Ma { get; set; }
        public virtual NsPhucap Ma1 { get; set; }
        public virtual Nhanvien MaNavigation { get; set; }
    }
}
