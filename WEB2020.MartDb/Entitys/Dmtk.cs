using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmtk
    {
        public string Matk { get; set; }
        public string Madonvi { get; set; }
        public string Maloaitk { get; set; }
        public string Matkcha { get; set; }
        public int? Tkchitiet { get; set; }
        public int? Bactk { get; set; }
        public int? Tinhchat { get; set; }
        public int? Trangthai { get; set; }
        public bool? Trangthaisd { get; set; }
        public string Tentk { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Dmloaitk MaloaitkNavigation { get; set; }
    }
}
