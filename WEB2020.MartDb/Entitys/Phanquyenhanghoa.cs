using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Phanquyenhanghoa
    {
        public string Madonvi { get; set; }
        public string Manhomquyen { get; set; }
        public string Manganh { get; set; }
        public string Manhomhang { get; set; }
        public bool? Trangthai { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Manhanvien { get; set; }

        public virtual Nganhhang Ma { get; set; }
        public virtual Nhomquyen Ma1 { get; set; }
        public virtual Nhomhang MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
