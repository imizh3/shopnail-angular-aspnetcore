using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsDangkynghict
    {
        public string Madangkynghi { get; set; }
        public int? Giovao { get; set; }
        public int? Giove { get; set; }
        public decimal? Heso { get; set; }
        public DateTime? Ngaydangky { get; set; }
        public int? Trangthaihuongluong { get; set; }
        public string Madonvi { get; set; }

        public virtual NsDangkynghi Mad { get; set; }
    }
}
