using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Dmloaichungtu
    {
        public Dmloaichungtu()
        {
            Dmchungtu = new HashSet<Dmchungtu>();
        }

        public string Maloaictu { get; set; }
        public string Tenloaictu { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Dmchungtu> Dmchungtu { get; set; }
    }
}
