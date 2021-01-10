using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class LichDathang
    {
        public int ItemId { get; set; }
        public string Makhachhang { get; set; }
        public string Madonvi { get; set; }
        public DateTime Ngaydat { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime Ngaytao { get; set; }
        public bool Trangthai { get; set; }
    }
}
