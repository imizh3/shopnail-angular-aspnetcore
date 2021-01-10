﻿using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class TsKhauhao
    {
        public TsKhauhao()
        {
            TsKhauhaoct = new HashSet<TsKhauhaoct>();
        }

        public string Madonvi { get; set; }
        public string Magiaodichpk { get; set; }
        public DateTime? Ngayhoachtoan { get; set; }
        public string Diengiai { get; set; }
        public string Manvlapbieu { get; set; }
        public int? Trangthai { get; set; }
        public string Maptnx { get; set; }
        public string Manhomptnx { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }

        public virtual ICollection<TsKhauhaoct> TsKhauhaoct { get; set; }
    }
}
