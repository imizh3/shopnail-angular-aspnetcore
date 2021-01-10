using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxKehoach
    {
        public SxKehoach()
        {
            SxKehoachcts = new HashSet<SxKehoachct>();
        }

        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Magiaodichphu { get; set; }
        public string Makhachhang { get; set; }
        public string Manvkinhdoanh { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public string Ghichu { get; set; }
        public string Tendangnhap { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public DateTime Ngaysanxuat { get; set; }
        public DateTime? Ngayketthuc { get; set; }

        public virtual ICollection<SxKehoachct> SxKehoachcts { get; set; }
    }
}
