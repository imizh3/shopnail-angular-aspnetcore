using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class DmVanchuyen
    {
        public string Madonvi { get; set; }
        public string Mavanchuyen { get; set; }
        public string Tenvanchuyen { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaysua { get; set; }
    }
}
