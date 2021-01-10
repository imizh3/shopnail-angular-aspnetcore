using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nhomhang
    {
        public Nhomhang()
        {
            Kiemkect = new HashSet<Kiemkect>();
            Mathang = new HashSet<Mathang>();
        }

        public string Manhomhang { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomhang { get; set; }
        public string Manganh { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime? Ngaytao { get; set; }
        public int? Madongbo { get; set; }
        public int? Trangthaidoanhso { get; set; }
        public int? Thutuin { get; set; }

        public virtual Nganhhang Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Nguoidung Nguoidung { get; set; }
        public virtual ICollection<Kiemkect> Kiemkect { get; set; }
        public virtual ICollection<Mathang> Mathang { get; set; }
    }
}
