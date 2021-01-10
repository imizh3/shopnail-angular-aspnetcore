using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Bohangct
    {
        public string Mabohang { get; set; }
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public int? Soluong { get; set; }
        public decimal? Tylechietkhaule { get; set; }
        public decimal? Tylechietkhaubuon { get; set; }
        public int? Trangthai { get; set; }
        public string Ghichu { get; set; }
        public decimal? Tongtienbanbuon { get; set; }
        public decimal? Tongtienbanle { get; set; }

        public virtual Bohang Ma { get; set; }
        public virtual Mathang MaNavigation { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
