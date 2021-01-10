using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsQdkhenthuongkyluat
    {
        public string Maquyetdinh { get; set; }
        public string Manhanvien { get; set; }
        public DateTime? Ngayphatsinh { get; set; }
        public string Ghichu { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Nhanvien Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
