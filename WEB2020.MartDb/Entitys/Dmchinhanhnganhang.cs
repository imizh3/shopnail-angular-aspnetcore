using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Dmchinhanhnganhang
    {
        public string Machinhanh { get; set; }
        public string Manganhang { get; set; }
        public string Tenchinhanh { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public string Email { get; set; }

        public virtual Dmnganhang ManganhangNavigation { get; set; }
    }
}
