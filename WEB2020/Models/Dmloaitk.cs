using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Dmloaitk
    {
        public Dmloaitk()
        {
            Dmtk = new HashSet<Dmtk>();
        }

        public string Maloaitk { get; set; }
        public string Tenloaitk { get; set; }

        public virtual ICollection<Dmtk> Dmtk { get; set; }
    }
}
