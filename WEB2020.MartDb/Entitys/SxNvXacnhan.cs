using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class SxNvXacnhan
    {
        public string Madonvi { get; set; }
        public string Manhanvien { get; set; }
        public string Maxacnhan { get; set; }
        public string Manghiepvu { get; set; }
        public int? Trangthai { get; set; }
        public string Ghichu { get; set; }

        public virtual SxDmXacnhan Ma { get; set; }
    }
}
