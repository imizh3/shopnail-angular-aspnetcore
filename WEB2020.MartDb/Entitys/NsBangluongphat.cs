using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBangluongphat
    {
        public string Mabangluong { get; set; }
        public string Manhanvien { get; set; }
        public string Makhenthuongkyluat { get; set; }
        public decimal? Sotien { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Madonvi { get; set; }

        public virtual NsBangluong Ma { get; set; }
        public virtual Nhanvien Ma1 { get; set; }
        public virtual NsKhenthuongkyluat MaNavigation { get; set; }
    }
}
