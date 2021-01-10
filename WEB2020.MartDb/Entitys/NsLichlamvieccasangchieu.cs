using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsLichlamvieccasangchieu
    {
        public string Maphongban { get; set; }
        public int? Giovaosang { get; set; }
        public int? Phutvaosang { get; set; }
        public int? Giovesang { get; set; }
        public int? Phutvesang { get; set; }
        public int? Gionghisang { get; set; }
        public int? Phutnghisang { get; set; }
        public int? Giovaochieu { get; set; }
        public int? Phutvaochieu { get; set; }
        public int? Giovechieu { get; set; }
        public int? Phutvechieu { get; set; }
        public int? Gionghichieu { get; set; }
        public int? Phutnghichieu { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual NsPhongban Ma { get; set; }
    }
}
