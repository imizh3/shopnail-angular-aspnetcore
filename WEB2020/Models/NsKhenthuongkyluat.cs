using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsKhenthuongkyluat
    {
        public string Makhenthuongkyluat { get; set; }
        public string Tenkhenthuongkyluat { get; set; }
        public int? Loai { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
