using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class TsNhomtaisan
    {
        public string Madonvi { get; set; }
        public string Manhomtaisan { get; set; }
        public string Tennhomtaisan { get; set; }
        public string Maloaitaisan { get; set; }
        public int Loaihang { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public int? Issudung { get; set; }
    }
}
