using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class TsGiaodich
    {
        public TsGiaodich()
        {
            TsGiaodichcts = new HashSet<TsGiaodichct>();
        }

        public string Madonvi { get; set; }
        public string Magiaodichpk { get; set; }
        public string Manhomptnx { get; set; }
        public string Maptnx { get; set; }
        public string Sohoadon { get; set; }
        public string Kyhieuhoadongd { get; set; }
        public DateTime? Ngayhoadon { get; set; }
        public DateTime? Ngayhoachtoan { get; set; }
        public string Ghichu { get; set; }
        public int? Trangthai { get; set; }
        public string Makhachhang { get; set; }
        public string Manhacungcap { get; set; }
        public string Maphongban { get; set; }
        public DateTime? Ngaytao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoitao { get; set; }
        public string Nguoisua { get; set; }
        public int? Sort { get; set; }

        public virtual ICollection<TsGiaodichct> TsGiaodichcts { get; set; }
    }
}
