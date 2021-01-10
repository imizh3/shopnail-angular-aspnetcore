using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Kiemke
    {
        public Kiemke()
        {
            Kiemkect = new HashSet<Kiemkect>();
        }

        public string Magiaodichpk { get; set; }
        public string Maptnx { get; set; }
        public string Madonvi { get; set; }
        public string Makhohang { get; set; }
        public string Manganhhang { get; set; }
        public string Manhomhang { get; set; }
        public string Makehang { get; set; }
        public string Mavtu { get; set; }
        public int Trangthai { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Manguoitao { get; set; }
        public string Mavuviecthua { get; set; }
        public string Mavuviecthieu { get; set; }

        public virtual Donvi MadonviNavigation { get; set; }
        public virtual ICollection<Kiemkect> Kiemkect { get; set; }
    }
}
