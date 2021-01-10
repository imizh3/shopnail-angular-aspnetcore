using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class DmLoaicongtrinh
    {
        public DmLoaicongtrinh()
        {
            DmCongtrinhs = new HashSet<DmCongtrinh>();
        }

        public string Madonvi { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Ghichu { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<DmCongtrinh> DmCongtrinhs { get; set; }
    }
}
