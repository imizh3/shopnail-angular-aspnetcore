using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nhomkhachhang
    {
        public string Manhomkhachhang { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomkhachhang { get; set; }
        public decimal? Tilechietkhau { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Maloaikhach { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
