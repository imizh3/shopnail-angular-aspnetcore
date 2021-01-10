namespace WEB2020.Model
{
    public class OrderRequest
    {
        public string trangThai { get; set; }
        public string maNhanVien { get; set; }

        public string tuNgay { get; set; }
        public string denNgay { get; set; }
        public string magiaodichpk { get; set;}  //for getOrderDetails

    }
}