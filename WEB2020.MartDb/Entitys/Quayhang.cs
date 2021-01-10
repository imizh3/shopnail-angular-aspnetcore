using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Quayhang
    {
        public string Maquay { get; set; }
        public string Tenquay { get; set; }
        public string Madonvi { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Makhohang { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
