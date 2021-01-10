using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmptnx
    {
        public Dmptnx()
        {
            Dathangs = new HashSet<Dathang>();
            Giaodiches = new HashSet<Giaodich>();
            Giaodichquays = new HashSet<Giaodichquay>();
        }

        public string Maptnx { get; set; }
        public string Madonvi { get; set; }
        public string Manhomptnx { get; set; }
        public string Tenptnx { get; set; }
        public string Tinhchat { get; set; }
        public string Kyhieu { get; set; }
        public string Matkno { get; set; }
        public string Matkco { get; set; }
        public string Matknhapkhauno { get; set; }
        public string Matknhapkhauco { get; set; }
        public string Matkthuedacbietno { get; set; }
        public string Matkthuedacbietco { get; set; }
        public string Matkthuegtgtno { get; set; }
        public string Matkthuegtgtco { get; set; }
        public string Matkchietkhauno { get; set; }
        public string Matkchietkhauco { get; set; }
        public string Matkgiamgiano { get; set; }
        public string Matkgiamgiaco { get; set; }
        public string Matklephino { get; set; }
        public string Matklephico { get; set; }
        public string Matkchiphino { get; set; }
        public string Matkchiphico { get; set; }
        public string Matkchiphikhacno { get; set; }
        public string Matkchiphikhacco { get; set; }
        public string Matkkhuyenmaino { get; set; }
        public string Matkkhuyenmaico { get; set; }
        public string Matkthuekhautruno { get; set; }
        public string Matkthuekhautruco { get; set; }
        public string Matkbanamno { get; set; }
        public string Matkbanamco { get; set; }
        public string Matkchietkhausaubanhangno { get; set; }
        public string Matkchietkhausaubanhangco { get; set; }
        public string Matknodf { get; set; }
        public string Matkcodf { get; set; }
        public string Matknhapkhaunodf { get; set; }
        public string Matknhapkhaucodf { get; set; }
        public string Matkthuedacbietnodf { get; set; }
        public string Matkthuedacbietcodf { get; set; }
        public string Matkthuegtgtnodf { get; set; }
        public string Matkthuegtgtcodf { get; set; }
        public string Matkchietkhaunodf { get; set; }
        public string Matkchietkhaucodf { get; set; }
        public string Matkgiamgianodf { get; set; }
        public string Matkgiamgiacodf { get; set; }
        public string Matklephinodf { get; set; }
        public string Matklephicodf { get; set; }
        public string Matkchiphinodf { get; set; }
        public string Matkchiphicodf { get; set; }
        public string Matkchiphikhacnodf { get; set; }
        public string Matkchiphikhaccodf { get; set; }
        public string Matkkhuyenmainodf { get; set; }
        public string Matkkhuyenmaicodf { get; set; }
        public string Matkthuekhautrunodf { get; set; }
        public string Matkthuekhautrucodf { get; set; }
        public string Matkbanamnodf { get; set; }
        public string Matkbanamcodf { get; set; }
        public string Matkchietkhausaubanhangnodf { get; set; }
        public string Matkchietkhausaubanhangcodf { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Cttienchietkhau { get; set; }
        public string Ctthanhtien { get; set; }
        public string Ctthucdoanhthu { get; set; }
        public string Matkvtu { get; set; }
        public string Matkgiavon { get; set; }
        public string Matkvtudf { get; set; }
        public string Matkgiavondf { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Hinhthuctt { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Dmnhomptnx ManhomptnxNavigation { get; set; }
        public virtual ICollection<Dathang> Dathangs { get; set; }
        public virtual ICollection<Giaodich> Giaodiches { get; set; }
        public virtual ICollection<Giaodichquay> Giaodichquays { get; set; }
    }
}
