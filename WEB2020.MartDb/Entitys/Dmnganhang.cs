using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmnganhang
    {
        public Dmnganhang()
        {
            Dmchinhanhnganhangs = new HashSet<Dmchinhanhnganhang>();
        }

        public string Manganhang { get; set; }
        public string Tennganhang { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public string Email { get; set; }
        public string Tenviettat { get; set; }

        public virtual ICollection<Dmchinhanhnganhang> Dmchinhanhnganhangs { get; set; }
    }
}
