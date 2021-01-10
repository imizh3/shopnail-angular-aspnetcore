using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class DmCongtrinh
    {
        public string Madonvi { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Maloaicongtrinh { get; set; }
        public int? Trangthai { get; set; }
        public decimal? Dutoan { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngayketthuc { get; set; }
        public string Makhachhang { get; set; }
        public string Diachi { get; set; }
        public string Ghichu { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoitao { get; set; }
        public string Nguoisua { get; set; }
        public int? Sort { get; set; }

        public virtual DmLoaicongtrinh MaNavigation { get; set; }
    }
}
