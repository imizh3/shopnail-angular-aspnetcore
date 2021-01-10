using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nhomquyen
    {
        public Nhomquyen()
        {
            Menunhomquyen = new HashSet<Menunhomquyen>();
            Nhomquyenphu = new HashSet<Nhomquyenphu>();
        }

        public string Manhomquyen { get; set; }
        public string Madonvi { get; set; }
        public string Tennhomquyen { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Ghichu { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Menunhomquyen> Menunhomquyen { get; set; }
        public virtual ICollection<Nhomquyenphu> Nhomquyenphu { get; set; }
    }
}
