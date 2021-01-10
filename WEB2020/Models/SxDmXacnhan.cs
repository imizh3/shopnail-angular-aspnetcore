using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class SxDmXacnhan
    {
        public SxDmXacnhan()
        {
            SxDmXacnhanct = new HashSet<SxDmXacnhanct>();
            SxNvXacnhan = new HashSet<SxNvXacnhan>();
        }

        public string Maxacnhan { get; set; }
        public string Madonvi { get; set; }
        public string Nghiepvu { get; set; }
        public string Ghichu { get; set; }

        public virtual ICollection<SxDmXacnhanct> SxDmXacnhanct { get; set; }
        public virtual ICollection<SxNvXacnhan> SxNvXacnhan { get; set; }
    }
}
