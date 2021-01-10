using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxDmcongthucsx
    {
        public SxDmcongthucsx()
        {
            SxDmcongthucsxct = new HashSet<SxDmcongthucsxct>();
        }

        public string Mactpk { get; set; }
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public string Tenct { get; set; }
        public int Trangthai { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime Ngaytao { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public string Ghichu { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<SxDmcongthucsxct> SxDmcongthucsxct { get; set; }
    }
}
