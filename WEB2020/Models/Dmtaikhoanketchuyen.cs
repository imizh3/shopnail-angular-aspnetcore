using System;
using System.Collections.Generic;

namespace WEB2020.Models
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
