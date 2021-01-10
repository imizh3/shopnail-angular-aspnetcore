using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsChuyenbophan
    {
        public string Machuyenbophan { get; set; }
        public string Tenchuyenbophan { get; set; }
        public string Manhanvien { get; set; }
        public string Mabophan { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }
        public int? Giovao { get; set; }
        public int? Giove { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Madonvi { get; set; }

        public virtual NsBophan Ma { get; set; }
        public virtual Nhanvien MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
