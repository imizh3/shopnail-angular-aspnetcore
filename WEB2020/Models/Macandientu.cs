using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Macandientu
    {
        public string Masieuthi { get; set; }
        public string Madonvi { get; set; }
        public string Itemcode { get; set; }
        public DateTime? Ngaytao { get; set; }

        public virtual Mathang Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
