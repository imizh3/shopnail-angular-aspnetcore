using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsCalamviec
    {
        public string Macalamviec { get; set; }
        public string Tencalamviec { get; set; }
        public int? Giovao { get; set; }
        public int? Phutvao { get; set; }
        public int? Giove { get; set; }
        public int? Phutve { get; set; }
        public int? Gionghigiuaca { get; set; }
        public int? Phutnghigiuaca { get; set; }
        public int? Gioktnghigiuaca { get; set; }
        public int? Phutktnghigiuaca { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Ghichu { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
    }
}
