using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxPhanbochiphichungct
    {
        public string Madonvi { get; set; }
        public string Maky { get; set; }
        public string Madoituongtaphop { get; set; }
        public decimal? Cpnguyenlieutructiep { get; set; }
        public decimal? Cpnhancongtructiep { get; set; }
        public decimal? Cpnhanconggiantiep { get; set; }
        public decimal? Cpnguyenlieugiantiep { get; set; }
        public decimal? Cpdungcusanxuat { get; set; }
        public decimal? Cpkhauhao { get; set; }
        public decimal? Cpmuangoai { get; set; }
        public decimal? Cpkhac { get; set; }
        public decimal? TilepbCpnltructiep { get; set; }
        public decimal? TilepbCpnlgiantiep { get; set; }
        public decimal? TilepbCpnhancongtructiep { get; set; }
        public decimal? TilepbCpnhanconggiantiep { get; set; }
        public decimal? TilepbCpdungcusanxuat { get; set; }
        public decimal? TilepbCpkhauhao { get; set; }
        public decimal? TilepbCpmuangoai { get; set; }
        public decimal? TilepbCpkhac { get; set; }
        public string Matk621 { get; set; }
        public string Matk622 { get; set; }
        public string Matk6271 { get; set; }
        public string Matk6272 { get; set; }
        public string Matk6273 { get; set; }
        public string Matk6274 { get; set; }
        public string Matk6277 { get; set; }
        public string Matk6278 { get; set; }

        public virtual SxKygiathanh Ma { get; set; }
    }
}
