using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsPhucap
    {
        public NsPhucap()
        {
            NsPhucapnhanviens = new HashSet<NsPhucapnhanvien>();
        }

        public string Maphucap { get; set; }
        public string Tenphucap { get; set; }
        public int? Trangthaiphucap { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<NsPhucapnhanvien> NsPhucapnhanviens { get; set; }
    }
}
