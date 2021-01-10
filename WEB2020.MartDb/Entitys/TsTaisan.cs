using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class TsTaisan
    {
        public TsTaisan()
        {
            TsGiaodichcts = new HashSet<TsGiaodichct>();
            TsKhauhaocts = new HashSet<TsKhauhaoct>();
        }

        public string Madonvi { get; set; }
        public string Mataisan { get; set; }
        public string Tentaisan { get; set; }
        public string Maloaitaisan { get; set; }
        public string Manhomtaisan { get; set; }
        public int? Loaihang { get; set; }
        public string Sohieutaisan { get; set; }
        public string Mancc { get; set; }
        public string Makmcpdv { get; set; }
        public int? Trangthaikd { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Madonvitinh { get; set; }
        public string Sophieubaohanh { get; set; }
        public string Namsx { get; set; }
        public string Nuocsx { get; set; }
        public string Maphongban { get; set; }
        public string Dieukienbh { get; set; }
        public string Sobbbangiao { get; set; }
        public string Phukien { get; set; }
        public DateTime? Ngaygiaonhan { get; set; }
        public DateTime? Ngaymua { get; set; }
        public DateTime? Ngayghitang { get; set; }
        public DateTime? Ngaysudung { get; set; }
        public DateTime? Ngaytinhkh { get; set; }
        public DateTime? Ngayhanbaohanh { get; set; }
        public DateTime? Ngayngungkh { get; set; }
        public DateTime? Ngaykhauhaogannhat { get; set; }
        public decimal? Nguyengia { get; set; }
        public decimal? Giatriconlai { get; set; }
        public decimal? Giatrikh { get; set; }
        public decimal? Haomonluyke { get; set; }
        public decimal? Haomonluykedk { get; set; }
        public decimal? Giatrikhnam { get; set; }
        public decimal? Giatrikhthang { get; set; }
        public decimal? Tylekhnam { get; set; }
        public decimal? Tylekhthang { get; set; }
        public int? Sothangdakhauhao { get; set; }
        public int? Songaydakhauhao { get; set; }
        public int? Songaykhconlai { get; set; }
        public int? Thangkhauhao { get; set; }
        public string Tknguyengia { get; set; }
        public string Tkkhauhao { get; set; }
        public string Tkchiphi { get; set; }
        public decimal? Quycach { get; set; }
        public string Mavatmua { get; set; }
        public string Mavatban { get; set; }
        public decimal? Giabanlecovat { get; set; }
        public decimal? Giabanbuoncovat { get; set; }
        public decimal? Giabanlechuavat { get; set; }
        public decimal? Giabanbuonchuavat { get; set; }
        public decimal? Giamuacovat { get; set; }
        public decimal? Giamuachuavat { get; set; }

        public virtual ICollection<TsGiaodichct> TsGiaodichcts { get; set; }
        public virtual ICollection<TsKhauhaoct> TsKhauhaocts { get; set; }
    }
}
