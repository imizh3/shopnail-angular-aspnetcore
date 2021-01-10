using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsBaohiem
    {
        public NsBaohiem()
        {
            NsBaohiemnhanviens = new HashSet<NsBaohiemnhanvien>();
        }

        public string Mabaohiem { get; set; }
        public string Tenbaohiem { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<NsBaohiemnhanvien> NsBaohiemnhanviens { get; set; }
    }
}
