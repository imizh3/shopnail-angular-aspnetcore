using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dathang
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Maptnx { get; set; }
        public string Ghichu { get; set; }
        public int? Trangthai { get; set; }
        public string Makhachhang { get; set; }
        public string Diachigiaohang { get; set; }
        public string Nguoinhanhang { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public DateTime? Ngaygiaodukien { get; set; }
        public DateTime? Ngaygiaothucte { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public string Magiaodichphu { get; set; }

        public virtual Dmptnx Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
