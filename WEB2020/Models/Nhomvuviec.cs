using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nhomvuviec
    {
        public Nhomvuviec()
        {
            Vuviec = new HashSet<Vuviec>();
        }

        public string Manhomvuviec { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomvuviec { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }

        public virtual ICollection<Vuviec> Vuviec { get; set; }
    }
}
