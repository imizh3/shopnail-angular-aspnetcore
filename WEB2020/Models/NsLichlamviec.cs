using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class NsLichlamviec
    {
        public NsLichlamviec()
        {
            NsGanlichlamviec = new HashSet<NsGanlichlamviec>();
        }

        public string Malichlamviec { get; set; }
        public string Tenlichlamviec { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<NsGanlichlamviec> NsGanlichlamviec { get; set; }
    }
}
