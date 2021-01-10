using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nganhhang
    {
        public Nganhhang()
        {
            Kiemkects = new HashSet<Kiemkect>();
            Mathangs = new HashSet<Mathang>();
            Nhomhangs = new HashSet<Nhomhang>();
        }

        public string Manganh { get; set; }
        public string Madonvi { get; set; }
        public string Tennganh { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public int? Madongbo { get; set; }
        public int? Loai { get; set; }
        public string Nhaphanphoi { get; set; }
        public string Kyhieu { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Kiemkect> Kiemkects { get; set; }
        public virtual ICollection<Mathang> Mathangs { get; set; }
        public virtual ICollection<Nhomhang> Nhomhangs { get; set; }
    }
}
