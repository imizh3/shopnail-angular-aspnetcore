using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nhomkmchiphi
    {
        public Nhomkmchiphi()
        {
            Kmchiphi = new HashSet<Kmchiphi>();
        }

        public string Manhomkmchiphi { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomkmchiphi { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public int Trangthaisudung { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Kmchiphi> Kmchiphi { get; set; }
    }
}
