using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsLuonghopdong
    {
        public NsLuonghopdong()
        {
            NsLuonghopdongbophans = new HashSet<NsLuonghopdongbophan>();
            NsLuonghopdongnhanviens = new HashSet<NsLuonghopdongnhanvien>();
        }

        public string Maluonghopdong { get; set; }
        public string Tenluonghopdong { get; set; }
        public int? Sothang { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<NsLuonghopdongbophan> NsLuonghopdongbophans { get; set; }
        public virtual ICollection<NsLuonghopdongnhanvien> NsLuonghopdongnhanviens { get; set; }
    }
}
