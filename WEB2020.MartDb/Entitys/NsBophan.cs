using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBophan
    {
        public NsBophan()
        {
            Nhanviens = new HashSet<Nhanvien>();
            NsBangchamcongs = new HashSet<NsBangchamcong>();
            NsBangluongs = new HashSet<NsBangluong>();
            NsChuyenbophans = new HashSet<NsChuyenbophan>();
            NsCongthuctinhluongs = new HashSet<NsCongthuctinhluong>();
            NsDangkylamthems = new HashSet<NsDangkylamthem>();
            NsDangkynghis = new HashSet<NsDangkynghi>();
            NsDinhmucluongs = new HashSet<NsDinhmucluong>();
            NsLuonghopdongbophans = new HashSet<NsLuonghopdongbophan>();
            NsNgaynghis = new HashSet<NsNgaynghi>();
        }

        public string Mabophan { get; set; }
        public string Tenbophan { get; set; }
        public int? Trangthaisudung { get; set; }
        public int? Trangthaiphat { get; set; }
        public decimal? Sogiolamtrenca { get; set; }
        public string Maphongban { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual NsPhongban Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
        public virtual ICollection<NsBangchamcong> NsBangchamcongs { get; set; }
        public virtual ICollection<NsBangluong> NsBangluongs { get; set; }
        public virtual ICollection<NsChuyenbophan> NsChuyenbophans { get; set; }
        public virtual ICollection<NsCongthuctinhluong> NsCongthuctinhluongs { get; set; }
        public virtual ICollection<NsDangkylamthem> NsDangkylamthems { get; set; }
        public virtual ICollection<NsDangkynghi> NsDangkynghis { get; set; }
        public virtual ICollection<NsDinhmucluong> NsDinhmucluongs { get; set; }
        public virtual ICollection<NsLuonghopdongbophan> NsLuonghopdongbophans { get; set; }
        public virtual ICollection<NsNgaynghi> NsNgaynghis { get; set; }
    }
}
