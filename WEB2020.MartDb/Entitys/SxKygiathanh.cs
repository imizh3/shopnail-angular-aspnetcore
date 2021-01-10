using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxKygiathanh
    {
        public SxKygiathanh()
        {
            SxKygiathanhcts = new HashSet<SxKygiathanhct>();
            SxPhanbochiphichungcts = new HashSet<SxPhanbochiphichungct>();
        }

        public string Madonvi { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime Tungay { get; set; }
        public DateTime Denngay { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Ky { get; set; }
        public int Nam { get; set; }
        public DateTime? Ngayphatsinh { get; set; }
        public int? Thang { get; set; }
        public int? Loaidanhgiadodang { get; set; }
        public int? Loai { get; set; }

        public virtual ICollection<SxKygiathanhct> SxKygiathanhcts { get; set; }
        public virtual ICollection<SxPhanbochiphichungct> SxPhanbochiphichungcts { get; set; }
    }
}
