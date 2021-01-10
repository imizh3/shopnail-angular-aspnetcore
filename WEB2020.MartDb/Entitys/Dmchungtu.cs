using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmchungtu
    {
        public string Mactu { get; set; }
        public string Madonvi { get; set; }
        public string Tenctu { get; set; }
        public string Matkno { get; set; }
        public string Matkco { get; set; }
        public bool? Trangthai { get; set; }
        public string Matknodf { get; set; }
        public string Matkcodf { get; set; }
        public string Kyhieuct { get; set; }
        public string Maloaictu { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Dmloaichungtu MaloaictuNavigation { get; set; }
    }
}
