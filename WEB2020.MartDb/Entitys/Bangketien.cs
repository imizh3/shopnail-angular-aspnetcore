using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Bangketien
    {
        public int Id { get; set; }
        public string Madonvi { get; set; }
        public string Mactpk { get; set; }
        public string Loaict { get; set; }
        public decimal? Sotien { get; set; }
        public decimal? Soluong { get; set; }
    }
}
