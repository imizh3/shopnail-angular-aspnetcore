using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBangluongct
    {
        public string Mabangluong { get; set; }
        public string Manhanvien { get; set; }
        public decimal? Songaylamviec { get; set; }
        public decimal? Songaynghi { get; set; }
        public decimal? Songaylamthem { get; set; }
        public decimal? Luonghopdong { get; set; }
        public decimal? Luonggiamsat { get; set; }
        public decimal? Luongtrachnhiem { get; set; }
        public decimal? Luongngay { get; set; }
        public decimal? Luongvanchuyen { get; set; }
        public decimal? Tienchailong { get; set; }
        public decimal? Tongluonglamthem { get; set; }
        public decimal? Tongphucap { get; set; }
        public decimal? Tongluongthuong { get; set; }
        public decimal? Tongtienphat { get; set; }
        public decimal? Baohiemxahoi { get; set; }
        public decimal? Thunhapkhac { get; set; }
        public decimal? Thucnhan { get; set; }
        public string Madonvi { get; set; }
        public decimal? Sogiolamthem { get; set; }
        public decimal? Sophutlamthem { get; set; }

        public virtual NsBangluong Ma { get; set; }
        public virtual Nhanvien MaNavigation { get; set; }
    }
}
