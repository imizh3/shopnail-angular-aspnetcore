﻿using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxKehoachct
    {
        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Masieuthi { get; set; }
        public decimal Soluong { get; set; }
        public string Mactpk { get; set; }

        public virtual SxKehoach Ma { get; set; }
    }
}
