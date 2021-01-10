using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class TsKhauhaoct
    {
        public string Madonvi { get; set; }
        public string Magiaodichpk { get; set; }
        public string Mataisan { get; set; }
        public string Tentaisan { get; set; }
        public string Maphongban { get; set; }
        public decimal? Giatrikh { get; set; }
        public decimal? Giatrikhthang { get; set; }
        public decimal? Giatrikhnam { get; set; }
        public decimal? Giatriconlai { get; set; }
        public decimal? Haomonluyke { get; set; }
        public decimal? Haomonluykedk { get; set; }
        public decimal? Giatriconlaidk { get; set; }
        public string Matkno { get; set; }
        public string Matkco { get; set; }
        public DateTime? Ngaytao { get; set; }
        public decimal? Songaytinhkh { get; set; }
        public decimal? Sothangdakhauhao { get; set; }
        public int? Pptinhkhauhao { get; set; }
        public decimal? Sothangconlaikhauhao { get; set; }
        public string Ctdoituong { get; set; }
        public int? Itemid { get; set; }
        public int? Sort { get; set; }

        public virtual TsKhauhao Ma { get; set; }
        public virtual TsTaisan MaNavigation { get; set; }
    }
}
