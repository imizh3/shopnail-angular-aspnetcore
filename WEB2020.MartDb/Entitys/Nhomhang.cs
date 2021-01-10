using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nhomhang
    {
        public Nhomhang()
        {
            Kiemkects = new HashSet<Kiemkect>();
            Mathangs = new HashSet<Mathang>();
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
        public int? Trangthaidoanhsonam { get; set; }

        public virtual Nganhhang Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Nguoidung Nguoidung { get; set; }
        public virtual ICollection<Kiemkect> Kiemkects { get; set; }
        public virtual ICollection<Mathang> Mathangs { get; set; }
    }
}
