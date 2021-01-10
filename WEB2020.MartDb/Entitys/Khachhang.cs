using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Khachhang
    {
        public string Makhachhang { get; set; }
        public string Maloaikhach { get; set; }
        public string Madonvi { get; set; }
        public string Manhomkhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public string Dienthoai2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Masothue { get; set; }
        public int? Trangthai { get; set; }
        public decimal? Congnomax { get; set; }
        public string Matuyen { get; set; }
        public string Diachigiaohang { get; set; }
        public string Nguoigiaodich { get; set; }
        public decimal? Diem { get; set; }
        public decimal? Doanhso { get; set; }
        public string Mathe { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public int? Gioitinh { get; set; }
        public int? Madongbo { get; set; }
        public string Motakhachhang { get; set; }
        public int? Songaythanhtoan { get; set; }
        public int? Loaicongno { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
