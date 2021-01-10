using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Kichthuocsp
    {
        public string Masieuthi { get; set; }
        public string Madonvi { get; set; }
        public decimal? Chieucao { get; set; }
        public decimal? Chieurong { get; set; }
        public decimal? Chieudai { get; set; }
        public decimal? Trongluong { get; set; }

        public virtual Mathang Ma { get; set; }
    }
}
