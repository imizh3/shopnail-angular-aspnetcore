using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmnhomptnx
    {
        public Dmnhomptnx()
        {
            Dmptnxes = new HashSet<Dmptnx>();
        }

        public string Manhomptnx { get; set; }
        public string Tennhomptnx { get; set; }
        public string Ghichu { get; set; }
        public bool? Trangthai { get; set; }

        public virtual ICollection<Dmptnx> Dmptnxes { get; set; }
    }
}
