using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class GridSetting
    {
        public string Madonvi { get; set; }
        public string Formname { get; set; }
        public string Columnname { get; set; }
        public bool? Ishide { get; set; }
        public int? Position { get; set; }
        public double? Width { get; set; }
        public string Manhomquyen { get; set; }
    }
}
