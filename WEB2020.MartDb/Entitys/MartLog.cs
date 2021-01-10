using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class MartLog
    {
        public int Id { get; set; }
        public string Madonvi { get; set; }
        public string Malog { get; set; }
        public string Nguoitao { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tenmay { get; set; }
        public string Tenform { get; set; }
        public string Trangthai { get; set; }
        public string Noidung { get; set; }
        public string NoidungShort { get; set; }
    }
}
