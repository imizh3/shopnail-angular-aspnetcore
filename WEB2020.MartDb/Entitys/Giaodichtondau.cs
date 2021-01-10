using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Giaodichtondau
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Makhohang { get; set; }
        public string Manguoitao { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public DateTime? Ngaytao { get; set; }
        public int Trangthai { get; set; }
        public string Ghichu { get; set; }
    }
}
