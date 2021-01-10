using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nhomvattu
    {
        public string Manhom { get; set; }
        public string Tennhom { get; set; }
        public string Manhomcha { get; set; }
        public string Madonvi { get; set; }
        public int? Bac { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Nguoisua { get; set; }
    }
}
