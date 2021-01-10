using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Denghithanhtoan
    {
        public string Madenghi { get; set; }
        public string Madonvi { get; set; }
        public string Kieuct { get; set; }
        public string Mactu { get; set; }
        public string Soctkt { get; set; }
        public DateTime Ngayctkt { get; set; }
        public string Kemtheo { get; set; }
        public string Ghichu { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime? Ngayhoadon { get; set; }
        public string Sohoadon { get; set; }
        public string Kyhieuhoadon { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Nguoinoptien { get; set; }
        public string Mangoaite { get; set; }
        public decimal? Tygia { get; set; }
        public string Magiaodichphu { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
