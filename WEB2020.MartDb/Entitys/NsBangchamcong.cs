using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBangchamcong
    {
        public string Mabangchamcong { get; set; }
        public string Mabophan { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }
        public int? Trangthai { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngayphatsinh { get; set; }
        public string Ghichu { get; set; }

        public virtual NsBophan Ma { get; set; }
    }
}
