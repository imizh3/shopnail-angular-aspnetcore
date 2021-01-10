﻿using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Khachhanggia
    {
        public int Keys { get; set; }
        public string Makhachhang { get; set; }
        public int Maloaigia { get; set; }
        public string Maapdung { get; set; }
        public decimal Dongiaban { get; set; }
        public int Trangthaisudung { get; set; }
        public string Madonvi { get; set; }
        public string Manhanvien { get; set; }
        public string Manhomkhachhang { get; set; }
        public decimal? Tyleck { get; set; }
    }
}
