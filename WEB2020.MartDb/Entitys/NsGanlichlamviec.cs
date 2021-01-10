using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsGanlichlamviec
    {
        public string Maganlichlamviec { get; set; }
        public string Malichlamviec { get; set; }
        public string Manhanvien { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngayketthuc { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual NsLichlamviec Ma { get; set; }
        public virtual Nhanvien MaNavigation { get; set; }
    }
}
