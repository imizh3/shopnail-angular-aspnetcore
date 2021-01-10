using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsBangluongthuong
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
