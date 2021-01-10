using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Giaodichgiaonhan
    {
        public Giaodichgiaonhan()
        {
            Giaodichgiaonhanct = new HashSet<Giaodichgiaonhanct>();
        }

        public string Magiaodichpk { get; set; }
        public string Madonvi { get; set; }
        public string Ghichu { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Magiaodichphu { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public DateTime Ngayphatsinh { get; set; }
        public string Maquay { get; set; }

        public virtual ICollection<Giaodichgiaonhanct> Giaodichgiaonhanct { get; set; }
    }
}
