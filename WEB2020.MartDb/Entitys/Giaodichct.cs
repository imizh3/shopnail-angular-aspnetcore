using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Giaodichct
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public string Manganh { get; set; }
        public string Makhachhang { get; set; }
        public string Manhomhang { get; set; }
        public string Makhohang { get; set; }
        public string Mabohang { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Dongiacovat { get; set; }
        public decimal? Dongiachuavat { get; set; }
        public decimal? Tienhang { get; set; }
        public decimal? Tienvat { get; set; }
        public decimal? Thanhtien { get; set; }
        public decimal? Tyleck { get; set; }
        public decimal? Tienck { get; set; }
        public int? Sort { get; set; }
        public decimal? Giavon { get; set; }
        public decimal? Doanhthu { get; set; }
        public string Makhodieuchuyen { get; set; }
        public string Mavat { get; set; }
        public string Ghichu { get; set; }
        public decimal? Giabanlecovat { get; set; }
        public decimal? Giabanbuoncovat { get; set; }
        public decimal? Giabanlechuavat { get; set; }
        public decimal? Giabanbuonchuavat { get; set; }
        public decimal? Tylelaibuon { get; set; }
        public decimal? Tylelaile { get; set; }
        public decimal? Giathungchuavat { get; set; }
        public string Mavuviec { get; set; }
        public string Mangoaite { get; set; }
        public decimal? Tygia { get; set; }
        public string Magiaodichphu { get; set; }
        public string Machuongtrinhkm { get; set; }
        public string Mavatnk { get; set; }
        public decimal? Tienvatnk { get; set; }
        public decimal? Tienchiphivc { get; set; }
        public decimal? Tienchiphikhac { get; set; }
        public decimal? Tylecktrendon { get; set; }
        public decimal? Tiencktrendon { get; set; }
        public decimal? Tiencktrathuong { get; set; }
        public decimal? Dongiacovatnt { get; set; }
        public decimal? Dongiachuavatnt { get; set; }
        public decimal? Tienhangnt { get; set; }
        public decimal? Tienvatnt { get; set; }
        public decimal? Thanhtiennt { get; set; }
        public decimal? Tiencknt { get; set; }
        public decimal? Giavonnt { get; set; }
        public decimal? Doanhthunt { get; set; }
        public decimal? Giabanlecovatnt { get; set; }
        public decimal? Giabanbuoncovatnt { get; set; }
        public decimal? Giabanlechuavatnt { get; set; }
        public decimal? Giabanbuonchuavatnt { get; set; }
        public decimal? Giathungchuavatnt { get; set; }
        public decimal? Tienvatnknt { get; set; }
        public decimal? Tienchiphivcnt { get; set; }
        public decimal? Tienchiphikhacnt { get; set; }
        public decimal? Tiencktrendonnt { get; set; }
        public decimal? Tiencktrathuongnt { get; set; }
        public string Madoituongtaphop { get; set; }
        public string Mathanhpham { get; set; }
        public decimal? Tienhangtinhthue { get; set; }
        public string Mamau { get; set; }
        public string Macongtrinh { get; set; }
        public string Madvtinh { get; set; }

        public virtual Giaodich Ma { get; set; }
        public virtual Mathang MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
