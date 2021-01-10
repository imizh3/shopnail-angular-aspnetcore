using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmtaikhoanketchuyen
    {
        public string Matkketchuyen { get; set; }
        public string Madonvi { get; set; }
        public int? Nam { get; set; }
        public int? Thang { get; set; }
        public string Ghichu { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngayphatsinh { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
    }
}
