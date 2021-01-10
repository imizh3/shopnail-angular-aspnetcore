using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dinhmucdathang
    {
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public bool Chanthung { get; set; }
        public decimal Tonmax { get; set; }
        public decimal Tonmin { get; set; }
    }
}
