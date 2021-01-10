using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsLichlamviecctthang
    {
        public string Malichlamviecthang { get; set; }
        public DateTime? Ngaylamviec { get; set; }
        public string Mathutrongtuan { get; set; }
        public string Macalamviec { get; set; }
        public string Madonvi { get; set; }

        public virtual NsCalamviec Ma { get; set; }
        public virtual NsLichlamviecthang MaNavigation { get; set; }
    }
}
