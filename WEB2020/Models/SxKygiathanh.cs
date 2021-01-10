using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxKygiathanh
    {
        public SxKygiathanh()
        {
            SxKygiathanhct = new HashSet<SxKygiathanhct>();
            SxPhanbochiphichungct = new HashSet<SxPhanbochiphichungct>();
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

        public virtual ICollection<SxKygiathanhct> SxKygiathanhct { get; set; }
        public virtual ICollection<SxPhanbochiphichungct> SxPhanbochiphichungct { get; set; }
    }
}
