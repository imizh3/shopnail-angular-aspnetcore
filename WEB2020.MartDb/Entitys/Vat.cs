using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Vat
    {
        public string Mavat { get; set; }
        public string Madonvi { get; set; }
        public string Tenvat { get; set; }
        public int? Vat1 { get; set; }
        public string Congthuc { get; set; }
        public int? Loaivat { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime? Ngaytao { get; set; }
        public int? Khongchiuthue { get; set; }
        public string Doanhso { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime? Ngaysua { get; set; }
    }
}
