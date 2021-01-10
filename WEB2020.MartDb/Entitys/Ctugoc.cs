using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Ctugoc
    {
        public string Magiaodichpk { get; set; }
        public string Matk { get; set; }
        public string Matkdoiung { get; set; }
        public decimal? Sotienno { get; set; }
        public decimal? Sotienco { get; set; }
        public string Madonvi { get; set; }
        public string Manvcongno { get; set; }
        public string Makhachhang { get; set; }
        public string Makhohang { get; set; }
        public string Maloaict { get; set; }
        public string Ghichu { get; set; }
        public string Mavuviec { get; set; }
        public string Makmchiphi { get; set; }
        public string Madoituongtaphop { get; set; }
        public string Taikhoan { get; set; }
        public DateTime Ngayghiso { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Mangoaite { get; set; }
        public decimal? Tygia { get; set; }
        public decimal? Sotiennont { get; set; }
        public decimal? Sotiencont { get; set; }
        public string Magiaodichphu { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
