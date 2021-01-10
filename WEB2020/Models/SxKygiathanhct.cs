using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxKygiathanhct
    {
        public string Madonvi { get; set; }
        public string Ma { get; set; }
        public string Madoituongtaphop { get; set; }
        public decimal Soluong { get; set; }
        public decimal? Tilehoanthanh { get; set; }
        public decimal? Cpnguyenlieutructiep { get; set; }
        public decimal? Cpnguyenlieugiantiep { get; set; }
        public decimal? Cpnhancongtructiep { get; set; }
        public decimal? Cpnhanconggiantiep { get; set; }
        public decimal? Cpdungcusanxuat { get; set; }
        public decimal? Cpkhauhao { get; set; }
        public decimal? Cpmuangoai { get; set; }
        public decimal? Cpkhac { get; set; }
        public int? Sort { get; set; }
        public decimal? Giathanh { get; set; }
        public decimal? Soluongdodang { get; set; }

        public virtual SxKygiathanh MaNavigation { get; set; }
    }
}
