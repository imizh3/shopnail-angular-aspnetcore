using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Bohang
    {
        public Bohang()
        {
            Bohangcts = new HashSet<Bohangct>();
        }

        public string Mabohang { get; set; }
        public string Madonvi { get; set; }
        public string Tenbo { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaytao { get; set; }
        public int? Trangthai { get; set; }
        public string Ghichu { get; set; }
        public string Tendangnhap { get; set; }
        public string Barcode { get; set; }
        public DateTime? Ngayphatsinh { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Bohangct> Bohangcts { get; set; }
    }
}
