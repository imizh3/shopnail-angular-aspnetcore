using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Giaodichquay
    {
        public Giaodichquay()
        {
            Giaodichquaycts = new HashSet<Giaodichquayct>();
        }

        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Sochungtu { get; set; }
        public string Maptnx { get; set; }
        public int Trangthai { get; set; }
        public string Maquay { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Makhachhang { get; set; }
        public string Tendangnhap { get; set; }
        public string Manvcongno { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public int Thantoanthe { get; set; }
        public string Ghichu { get; set; }
        public decimal? Tienmat { get; set; }
        public decimal? Tienthe { get; set; }
        public decimal? Tiendoidiem { get; set; }
        public decimal? Tienqrcode { get; set; }

        public virtual Dmptnx Ma { get; set; }
        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Giaodichquayct> Giaodichquaycts { get; set; }
    }
}
