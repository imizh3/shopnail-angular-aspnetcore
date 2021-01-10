using System.Collections.Generic;
using WEB2020.Models;

namespace WEB2020.Model
{
    public class KhuyenmaiModel
    {
        public List<Khuyenmai> Khuyenmais { get; set; }
        public List<Khuyenmaict> Khuyenmaicts { get; set; }
        public List<Khuyenmaict> KmMotsosanpham { get; set; }
        public List<KhuyenmaimotsosanphamModel> KmMotsosanphamnew { get; set; }

    }
}