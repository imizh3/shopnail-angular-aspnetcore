﻿using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsDangkylamthemct
    {
        public string Madangkylamthem { get; set; }
        public int? Giovao { get; set; }
        public int? Giove { get; set; }
        public decimal? Heso { get; set; }
        public DateTime? Ngaydangky { get; set; }
        public string Madonvi { get; set; }
        public decimal? Sotien { get; set; }

        public virtual NsDangkylamthem Mad { get; set; }
    }
}
