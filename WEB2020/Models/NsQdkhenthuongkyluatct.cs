using System;
using System.Collections.Generic;

namespace WEB2020.Models
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
