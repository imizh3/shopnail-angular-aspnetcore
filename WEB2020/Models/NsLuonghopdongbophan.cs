using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsLuonghopdongbophan
    {
        public string Maluonghopdong { get; set; }
        public string Mabophan { get; set; }
        public decimal? Sotien { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual NsBophan Ma { get; set; }
        public virtual NsLuonghopdong MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
