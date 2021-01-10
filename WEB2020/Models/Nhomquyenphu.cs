using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nhomquyenphu
    {
        public string Manhomquyen { get; set; }
        public string Menuid { get; set; }
        public string Madonvi { get; set; }
        public string Chucnangphu { get; set; }
        public bool Trangthai { get; set; }

        public virtual Nhomquyen Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
