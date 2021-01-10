using System;
using System.Collections.Generic;

namespace WEB2020.Models
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
