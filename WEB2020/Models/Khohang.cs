using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Khohang
    {
        public Khohang()
        {
            Giaodichquayct = new HashSet<Giaodichquayct>();
        }

        public string Makhohang { get; set; }
        public string Madonvi { get; set; }
        public string Maloaikho { get; set; }
        public string Tenkhohang { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Ghichu { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string MaptnxTienmat { get; set; }
        public string MaptnxThe { get; set; }
        public string Dienthoai { get; set; }
        public string Manhanvien { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Giaodichquayct> Giaodichquayct { get; set; }
    }
}
