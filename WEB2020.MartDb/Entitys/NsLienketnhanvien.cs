using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsLienketnhanvien
    {
        public string Mabophanlamthem { get; set; }
        public string Manhanvienchinh { get; set; }
        public string Manhanvienphu { get; set; }
        public decimal? Hesoluong { get; set; }
        public string Madonvi { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaytao { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
