using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Kmchiphi
    {
        public string Makmchiphi { get; set; }
        public string Madonvi { get; set; }
        public string Tenkmchiphi { get; set; }
        public string Manhomkmchiphi { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Tendangnhap { get; set; }

        public virtual Nhomkmchiphi Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
