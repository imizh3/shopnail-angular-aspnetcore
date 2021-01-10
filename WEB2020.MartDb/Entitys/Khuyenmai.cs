using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Khuyenmai
    {
        public Khuyenmai()
        {
            Khuyenmaicts = new HashSet<Khuyenmaict>();
        }

        public string Machuongtrinh { get; set; }
        public string Madonvi { get; set; }
        public int Loaiapdung { get; set; }
        public int Maloaichuongtrinh { get; set; }
        public string Tenchuongtrinh { get; set; }
        public int? Trangthai { get; set; }
        public int? Trangthaikm { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngayketthuc { get; set; }
        public int? Giobatdau { get; set; }
        public int? Gioketthuc { get; set; }
        public int? Phutbatdau { get; set; }
        public int? Phutkethuc { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngayphatsinh { get; set; }
        public string Mact { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Diengiaikm { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Khuyenmaict> Khuyenmaicts { get; set; }
    }
}
