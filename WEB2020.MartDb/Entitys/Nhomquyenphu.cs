using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
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
