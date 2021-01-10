using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsBaohiemnhanvien
    {
        public string Mabaohiem { get; set; }
        public string Manhanvien { get; set; }
        public string Maluongcoban { get; set; }
        public decimal? Heso { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual NsBaohiem Ma { get; set; }
        public virtual Nhanvien MaNavigation { get; set; }
    }
}
