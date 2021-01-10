using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsPhongban
    {
        public NsPhongban()
        {
            Nhanviens = new HashSet<Nhanvien>();
            NsBangluongs = new HashSet<NsBangluong>();
            NsBophans = new HashSet<NsBophan>();
            NsCongthuctinhluongs = new HashSet<NsCongthuctinhluong>();
            NsDinhmucluongs = new HashSet<NsDinhmucluong>();
        }

        public string Maphongban { get; set; }
        public string Tenphongban { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual NsLichlamvieccasangchieu NsLichlamvieccasangchieu { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
        public virtual ICollection<NsBangluong> NsBangluongs { get; set; }
        public virtual ICollection<NsBophan> NsBophans { get; set; }
        public virtual ICollection<NsCongthuctinhluong> NsCongthuctinhluongs { get; set; }
        public virtual ICollection<NsDinhmucluong> NsDinhmucluongs { get; set; }
    }
}
