using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Donvitinh
    {
        public Donvitinh()
        {
            Mathang = new HashSet<Mathang>();
        }

        public string Madvtinh { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Donvile { get; set; }
        public string Donvilon { get; set; }
        public string Tendangnhap { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Nguoidung Nguoidung { get; set; }
        public virtual ICollection<Mathang> Mathang { get; set; }
    }
}
