using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            Donvitinh = new HashSet<Donvitinh>();
            Nhomhang = new HashSet<Nhomhang>();
        }

        public string Madonvi { get; set; }
        public string Tendangnhap { get; set; }
        public string Manhomquyen { get; set; }
        public string Hovaten { get; set; }
        public int? Trangthai { get; set; }
        public string Matkhau { get; set; }
        public string Sodienthoai { get; set; }
        public string Email { get; set; }
        public string Manguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Manguoisua { get; set; }
        public string Manvcongno { get; set; }
        public string Trangthaiof { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Donvitinh> Donvitinh { get; set; }
        public virtual ICollection<Nhomhang> Nhomhang { get; set; }
    }
}
