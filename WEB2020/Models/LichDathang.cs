using System;
using System.Collections.Generic;

namespace WEB2020.Models
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
