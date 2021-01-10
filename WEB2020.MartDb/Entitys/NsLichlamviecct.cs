using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsLichlamviecct
    {
        public string Malichlamviec { get; set; }
        public string Mathutrongtuan { get; set; }
        public string Macalamviec { get; set; }
        public string Madonvi { get; set; }

        public virtual NsCalamviec Ma { get; set; }
        public virtual NsLichlamviec MaNavigation { get; set; }
    }
}
