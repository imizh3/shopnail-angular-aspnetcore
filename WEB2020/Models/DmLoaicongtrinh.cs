using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class DmLoaicongtrinh
    {
        public DmLoaicongtrinh()
        {
            DmCongtrinh = new HashSet<DmCongtrinh>();
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

        public virtual ICollection<DmCongtrinh> DmCongtrinh { get; set; }
    }
}
