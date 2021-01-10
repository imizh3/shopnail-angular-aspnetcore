using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsPhucapnhanvien
    {
        public string Maphucap { get; set; }
        public string Manhanvien { get; set; }
        public decimal? Sotien { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngayketthuc { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Nhanvien Ma { get; set; }
        public virtual NsPhucap MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
