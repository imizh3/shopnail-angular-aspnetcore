using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class DmCachdonggoi
    {
        public string Madonvi { get; set; }
        public string Madonggoi { get; set; }
        public string Tendonggoi { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaysua { get; set; }
    }
}
