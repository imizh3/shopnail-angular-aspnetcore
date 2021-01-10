using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Menunhomquyen
    {
        public string Manhomquyen { get; set; }
        public string Menuid { get; set; }
        public string Madonvi { get; set; }
        public bool? Them { get; set; }
        public bool? Sua { get; set; }
        public bool? Xoa { get; set; }
        public bool? Luutam { get; set; }
        public bool? Luuthuc { get; set; }
        public bool? Khoiphuc { get; set; }
        public bool? Xem { get; set; }
        public string Manguoitao { get; set; }
        public DateTime Ngaytao { get; set; }
        public bool? GridSetting { get; set; }
        public bool? SolieutheoUser { get; set; }

        public virtual Nhomquyen Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
    }
}
