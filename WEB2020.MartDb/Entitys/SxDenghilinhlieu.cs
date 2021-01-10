using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxDenghilinhlieu
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public int Tinhtrang { get; set; }
        public string Ghichu { get; set; }
        public string Magiaodichphu { get; set; }
        public int Trangthai { get; set; }
        public DateTime? Ngaylinhlieu { get; set; }
        public string Mahopdong { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaysua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
