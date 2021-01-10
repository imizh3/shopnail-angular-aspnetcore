using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Donvitinh
    {
        public Donvitinh()
        {
            Mathangs = new HashSet<Mathang>();
        }

        public string Madvtinh { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Donvile { get; set; }
        public string Donvilon { get; set; }
        public string Tendangnhap { get; set; }
        public string Madonvile { get; set; }
        public string Madonvilon { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Nguoidung Nguoidung { get; set; }
        public virtual ICollection<Mathang> Mathangs { get; set; }
    }
}
