using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBangchamcongct
    {
        public string Mabangchamcong { get; set; }
        public string Manhanvien { get; set; }
        public string Madonvi { get; set; }
        public string Machamcong { get; set; }
        public int? Giovao { get; set; }
        public int? Phutvao { get; set; }
        public int? Giove { get; set; }
        public int? Phutve { get; set; }
        public int? Giovaothucte { get; set; }
        public int? Phutvaothucte { get; set; }
        public int? Giovethucte { get; set; }
        public int? Phutvethucte { get; set; }
        public DateTime? Ngaylamviec { get; set; }
        public int? Giovaolamthem { get; set; }
        public int? Giovelamthem { get; set; }
        public decimal? Tyleluonglamthem { get; set; }
        public int? Sophutdimuon { get; set; }
        public int? Sophutvesom { get; set; }
        public decimal? Tongsogiolam { get; set; }
        public decimal? Tongsogiolamthem { get; set; }
        public decimal? SotienLuonglamthem { get; set; }

        public virtual NsBangchamcong Ma { get; set; }
        public virtual Nhanvien MaNavigation { get; set; }
    }
}
