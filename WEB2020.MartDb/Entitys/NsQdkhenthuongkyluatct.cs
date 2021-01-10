using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsQdkhenthuongkyluatct
    {
        public string Maquyetdinh { get; set; }
        public string Makhenthuongkyluat { get; set; }
        public decimal? Sotien { get; set; }
        public string Madonvi { get; set; }

        public virtual NsKhenthuongkyluat Ma { get; set; }
        public virtual NsQdkhenthuongkyluat MaNavigation { get; set; }
    }
}
