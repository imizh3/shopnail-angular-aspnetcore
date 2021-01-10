using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nganhhang
    {
        public Nganhhang()
        {
            Kiemkect = new HashSet<Kiemkect>();
            Mathang = new HashSet<Mathang>();
            Nhomhang = new HashSet<Nhomhang>();
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
        public virtual ICollection<Kiemkect> Kiemkect { get; set; }
        public virtual ICollection<Mathang> Mathang { get; set; }
        public virtual ICollection<Nhomhang> Nhomhang { get; set; }
    }
}
