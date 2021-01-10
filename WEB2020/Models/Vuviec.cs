using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Vuviec
    {
        public string Mavuviec { get; set; }
        public string Madonvi { get; set; }
        public string Tenvuviec { get; set; }
        public string Manhomvuviec { get; set; }
        public int? Trangthai { get; set; }
        public int? Trangthaisudung { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }

        public virtual Nhomvuviec Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
