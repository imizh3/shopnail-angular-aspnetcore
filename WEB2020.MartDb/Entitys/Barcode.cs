using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Barcode
    {
        public string Masieuthi { get; set; }
        public string Barcode1 { get; set; }
        public string Madonvi { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
