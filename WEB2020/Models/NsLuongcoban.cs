using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsLuongcoban
    {
        public string Maluongcoban { get; set; }
        public string Tenluongcoban { get; set; }
        public decimal? Sotien { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
