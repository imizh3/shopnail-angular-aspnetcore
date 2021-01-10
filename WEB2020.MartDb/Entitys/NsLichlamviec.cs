using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class NsLichlamviec
    {
        public NsLichlamviec()
        {
            NsGanlichlamviecs = new HashSet<NsGanlichlamviec>();
        }

        public string Malichlamviec { get; set; }
        public string Tenlichlamviec { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<NsGanlichlamviec> NsGanlichlamviecs { get; set; }
    }
}
