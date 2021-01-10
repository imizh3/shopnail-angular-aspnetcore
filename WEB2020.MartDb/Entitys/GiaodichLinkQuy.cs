using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class GiaodichLinkQuy
    {
        public string Magiaodichpk { get; set; }
        public string Mactktpk { get; set; }
        public string Madonvi { get; set; }
        public decimal? Sotienthanhtoan { get; set; }
        public decimal? Sotienthanhtoannt { get; set; }
        public int? Loai { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public string Makhachhang { get; set; }
        public string Matk { get; set; }
    }
}
