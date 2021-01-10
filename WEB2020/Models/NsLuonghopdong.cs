using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsLuonghopdong
    {
        public NsLuonghopdong()
        {
            NsLuonghopdongbophan = new HashSet<NsLuonghopdongbophan>();
            NsLuonghopdongnhanvien = new HashSet<NsLuonghopdongnhanvien>();
        }

        public string Maluonghopdong { get; set; }
        public string Tenluonghopdong { get; set; }
        public int? Sothang { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<NsLuonghopdongbophan> NsLuonghopdongbophan { get; set; }
        public virtual ICollection<NsLuonghopdongnhanvien> NsLuonghopdongnhanvien { get; set; }
    }
}
