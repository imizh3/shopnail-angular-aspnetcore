using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsBophan
    {
        public NsBophan()
        {
            Nhanvien = new HashSet<Nhanvien>();
            NsBangchamcong = new HashSet<NsBangchamcong>();
            NsBangluong = new HashSet<NsBangluong>();
            NsChuyenbophan = new HashSet<NsChuyenbophan>();
            NsCongthuctinhluong = new HashSet<NsCongthuctinhluong>();
            NsDangkylamthem = new HashSet<NsDangkylamthem>();
            NsDangkynghi = new HashSet<NsDangkynghi>();
            NsDinhmucluong = new HashSet<NsDinhmucluong>();
            NsLuonghopdongbophan = new HashSet<NsLuonghopdongbophan>();
            NsNgaynghi = new HashSet<NsNgaynghi>();
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
        public virtual ICollection<Nhanvien> Nhanvien { get; set; }
        public virtual ICollection<NsBangchamcong> NsBangchamcong { get; set; }
        public virtual ICollection<NsBangluong> NsBangluong { get; set; }
        public virtual ICollection<NsChuyenbophan> NsChuyenbophan { get; set; }
        public virtual ICollection<NsCongthuctinhluong> NsCongthuctinhluong { get; set; }
        public virtual ICollection<NsDangkylamthem> NsDangkylamthem { get; set; }
        public virtual ICollection<NsDangkynghi> NsDangkynghi { get; set; }
        public virtual ICollection<NsDinhmucluong> NsDinhmucluong { get; set; }
        public virtual ICollection<NsLuonghopdongbophan> NsLuonghopdongbophan { get; set; }
        public virtual ICollection<NsNgaynghi> NsNgaynghi { get; set; }
    }
}
