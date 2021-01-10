using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxDmXacnhan
    {
        public SxDmXacnhan()
        {
            SxDmXacnhancts = new HashSet<SxDmXacnhanct>();
            SxNvXacnhans = new HashSet<SxNvXacnhan>();
        }

        public string Maxacnhan { get; set; }
        public string Madonvi { get; set; }
        public string Nghiepvu { get; set; }
        public string Ghichu { get; set; }

        public virtual ICollection<SxDmXacnhanct> SxDmXacnhancts { get; set; }
        public virtual ICollection<SxNvXacnhan> SxNvXacnhans { get; set; }
    }
}
