using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmloaitk
    {
        public Dmloaitk()
        {
            Dmtks = new HashSet<Dmtk>();
        }

        public string Maloaitk { get; set; }
        public string Tenloaitk { get; set; }

        public virtual ICollection<Dmtk> Dmtks { get; set; }
    }
}
