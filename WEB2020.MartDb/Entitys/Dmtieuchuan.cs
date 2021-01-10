using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmtieuchuan
    {
        public string Madonvi { get; set; }
        public string Matieuchuan { get; set; }
        public int Maloaitieuchuan { get; set; }
        public string Tentieuchuan { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaysua { get; set; }
    }
}
