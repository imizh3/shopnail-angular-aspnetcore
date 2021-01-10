using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Mathang
    {
        public Mathang()
        {
            Bohangcts = new HashSet<Bohangct>();
            Giaodichquaycts = new HashSet<Giaodichquayct>();
            Kiemkects = new HashSet<Kiemkect>();
            Macandientus = new HashSet<Macandientu>();
        }

        public string Masieuthi { get; set; }
        public string Madonvi { get; set; }
        public string Manganh { get; set; }
        public string Manhomhang { get; set; }
        public string Makhachhang { get; set; }
        public string Madvtinh { get; set; }
        public string Tendaydu { get; set; }
        public string Tenviettat { get; set; }
        public string Mahangcuancc { get; set; }
        public string Mavatmua { get; set; }
        public string Mavatban { get; set; }
        public int? Trangthaikd { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Barcode { get; set; }
        public decimal? Quycach { get; set; }
        public decimal? Giabanlecovat { get; set; }
        public decimal? Giabanbuoncovat { get; set; }
        public decimal? Giabanlechuavat { get; set; }
        public decimal? Giabanbuonchuavat { get; set; }
        public decimal? Giamuacovat { get; set; }
        public decimal? Giamuachuavat { get; set; }
        public decimal? Tylelaibuon { get; set; }
        public decimal? Tylelaile { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public string Itemcode { get; set; }
        public bool? QuanlySerial { get; set; }
        public string Thoigianbaohanh { get; set; }
        public string Kieubaohanh { get; set; }
        public string Makehang { get; set; }
        public int? Madongbo { get; set; }
        public decimal? Hieusuat { get; set; }
        public string Mavatnk { get; set; }
        public string Mahaiquan { get; set; }
        public string Mota { get; set; }
        public string Mahs { get; set; }
        public string Mactpk { get; set; }
        public string Maplv { get; set; }
        public decimal? Tyleckmua { get; set; }
        public decimal? Tyleckban { get; set; }
        public decimal? Giathungbuonchuavat { get; set; }
        public decimal? Giathungbuoncovat { get; set; }

        public virtual Nganhhang Ma { get; set; }
        public virtual Nhomhang MaNavigation { get; set; }
        public virtual Donvitinh Mad { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
        public virtual Kichthuocsp Kichthuocsp { get; set; }
        public virtual ICollection<Bohangct> Bohangcts { get; set; }
        public virtual ICollection<Giaodichquayct> Giaodichquaycts { get; set; }
        public virtual ICollection<Kiemkect> Kiemkects { get; set; }
        public virtual ICollection<Macandientu> Macandientus { get; set; }
    }
}
