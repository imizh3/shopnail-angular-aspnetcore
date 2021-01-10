﻿using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxDutinhNvlct
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public decimal Soluong { get; set; }
        public decimal? Toncuoikysl { get; set; }
        public decimal? Soluongnhap { get; set; }
        public decimal? Soluongdutinh { get; set; }
        public string Ghichu { get; set; }

        public virtual SxDutinhNvl Ma { get; set; }
    }
}
