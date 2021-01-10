using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nhomvuviec
    {
        public Nhomvuviec()
        {
            Vuviecs = new HashSet<Vuviec>();
        }

        public string Manhomvuviec { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomvuviec { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }

        public virtual ICollection<Vuviec> Vuviecs { get; set; }
    }
}
