using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsChucvu
    {
        public NsChucvu()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public string Machucvu { get; set; }
        public string Tenchucvu { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
