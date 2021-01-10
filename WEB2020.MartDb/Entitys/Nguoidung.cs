using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            Donvitinhs = new HashSet<Donvitinh>();
            Nhomhangs = new HashSet<Nhomhang>();
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
        //public string Makhohang { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Donvitinh> Donvitinhs { get; set; }
        public virtual ICollection<Nhomhang> Nhomhangs { get; set; }
    }
}
