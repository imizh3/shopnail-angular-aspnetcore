using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsPhongban
    {
        public NsPhongban()
        {
            Nhanvien = new HashSet<Nhanvien>();
            NsBangluong = new HashSet<NsBangluong>();
            NsBophan = new HashSet<NsBophan>();
            NsCongthuctinhluong = new HashSet<NsCongthuctinhluong>();
            NsDinhmucluong = new HashSet<NsDinhmucluong>();
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
        public virtual ICollection<Nhanvien> Nhanvien { get; set; }
        public virtual ICollection<NsBangluong> NsBangluong { get; set; }
        public virtual ICollection<NsBophan> NsBophan { get; set; }
        public virtual ICollection<NsCongthuctinhluong> NsCongthuctinhluong { get; set; }
        public virtual ICollection<NsDinhmucluong> NsDinhmucluong { get; set; }
    }
}
