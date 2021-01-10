using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class TsLoaitaisan
    {
        public string Madonvi { get; set; }
        public string Maloaitaisan { get; set; }
        public string Tenloaitaisan { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public int? Issudung { get; set; }
        public int Loaihang { get; set; }
    }
}
