using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Dmnhomptnx
    {
        public Dmnhomptnx()
        {
            Dmptnx = new HashSet<Dmptnx>();
        }

        public string Manhomptnx { get; set; }
        public string Tennhomptnx { get; set; }
        public string Ghichu { get; set; }
        public bool? Trangthai { get; set; }

        public virtual ICollection<Dmptnx> Dmptnx { get; set; }
    }
}
