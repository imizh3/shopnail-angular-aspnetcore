using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nhomquyen
    {
        public Nhomquyen()
        {
            Menunhomquyens = new HashSet<Menunhomquyen>();
            Nhomquyenphus = new HashSet<Nhomquyenphu>();
        }

        public string Manhomquyen { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomquyen { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Ghichu { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Menunhomquyen> Menunhomquyens { get; set; }
        public virtual ICollection<Nhomquyenphu> Nhomquyenphus { get; set; }
    }
}
