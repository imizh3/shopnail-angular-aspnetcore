using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxDmXacnhanct
    {
        public string Madonvi { get; set; }
        public string Maxacnhan { get; set; }
        public string Manhanvien { get; set; }
        public int? Capdo { get; set; }

        public virtual SxDmXacnhan Ma { get; set; }
    }
}
