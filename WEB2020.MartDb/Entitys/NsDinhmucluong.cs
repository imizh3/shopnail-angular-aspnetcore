using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsDinhmucluong
    {
        public string Madinhmucluong { get; set; }
        public string Maphongban { get; set; }
        public string Mabophan { get; set; }
        public decimal? Dinhmucluong { get; set; }
        public int? Dinhmucnhansu { get; set; }
        public int? Trangthaisudung { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Madonvi { get; set; }

        public virtual NsBophan Ma { get; set; }
        public virtual NsPhongban MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
