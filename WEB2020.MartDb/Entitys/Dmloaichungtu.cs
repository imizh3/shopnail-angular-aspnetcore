using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmloaichungtu
    {
        public Dmloaichungtu()
        {
            Dmchungtus = new HashSet<Dmchungtu>();
        }

        public string Maloaictu { get; set; }
        public string Tenloaictu { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Dmchungtu> Dmchungtus { get; set; }
    }
}
