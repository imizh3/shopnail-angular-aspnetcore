using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WEB2020.Data
{
    public class LIB
    {
        #region Khai báo các tham số hệ thống (lưu ý mã tham số tự tăng 01,02,03...)
        public static string mtsKhoasongaycu = "01", TenKhoasongaycu = "Khóa sổ dữ liệu ngày quá khứ";
        public static string mtsNgayphatsinhTudong = "02", TenNgayphatsinhTudong = "Lấy ngày phát sinh các giao dịch theo ngày hệ thống của máy chủ";
        public static string mtsTrangthaiHTKT = "03", TenTrangthaiHTKT = "Hạch toán kế toán";
        public static string mtsDinhdangsotien = "04", TenDinhdangsotien = "Định dạng số tiền cho hệ thống";
        public static string mtsDinhdangsosoluong = "05", TenDinhdangsosoluong = "Định dạng số lượng cho hệ thống";
        public static string mtsChophepIntemGiaodichLuutam = "06", TenChophepIntemGiaodichLuutam = "Cho phép in tem từ phiếu lưu tạm";
        public static string mtsUpdateGiabanTuPhieuNhap = "07", TenUpdateGiabanTuPhieuNhap = "Cho phép cập nhật giá bán từ phiếu nhập vào danh mục mặt hàng";
        public static string mtsNhapXuatKhoQuydinh = "08", TenNhapXuatKhoQuydinh = "Chỉ được nhập xuất theo kho đã quy định ";
        public static string mtsKhobanle = "09", TenKhobanle = "Cài đặt kho hàng bán lẻ";
        public static string mtsKhoKhuyenmai = "10", TenKhoKhuyenmai = "Cặt đặt kho khuyến mại bán lẻ";
        public static string mtsKhoAm = "11", TenKhoAm = "Cài đặt kho hàng bán lẻ âm";
        public static string mtsMaptBanle = "12", TenMaptBanle = "Cài đặt mã phương thức xuất bán lẻ";
        public static string mtsKhachhangBanle = "13", TenKhachhangBanle = "Cài đặt mã khách hàng bán lẻ";
        public static string mtsBanAm = "14", TenBanAm = "Cài đặt cho phép bán âm hay không";
        public static string mtsLamTronChuSo = "15", TenLamTronChuSo = "Làm tròn các số vô tỉ đến sô";
        public static string mtsMacanDientu = "16", TenMacanDientu = "Mã nhận dạng cân điện tử";
        public static string mtsGopMaboBanle = "17", TenGopMaboBanle = "Gộp mã bó hàng trên màn hình bán lẻ";
        public static string mtsTrutongBanle = "18", TenTrutongBanle = "Cài đặt trạng thái trừ tồn trực tiếp bán lẻ";
        public static string mtsTichLuyDoanhSo = "19", TenTichLuyDoanhSo = "Cài đặt trạng thái có tích lũy doanh số khách hàng hay không";
        public static string mtsSobanInBill = "20", TenSobanInBill = "Cài đặt số lượng liên in hóa đơn bán lẻ";
        public static string mtsCachTinhDiem = "21", TenCachTinhDiem = "Cài đặt cách tính điểm tích lũy khách hàng thân thiết";
        public static string mtsMaychuCapma = "22", TenMaychuCapma = "Địa chỉ máy chủ cấp mã hệ thống";
        public static string mtsKetnoiCapMa = "23", TenKetnoiCapMa = "Xác định đơn vị có kết nối đến hệ thống cấp mã tập trung";
        public static string mtsHienthiGianhap = "24", TenHienthiGianhap = "Cho phép hiển thị giá nhập trong ô tìm kiếm tại màn hình xuất bán";
        public static string mtsNhaptralaiTheophieuxuat = "25", TenNhaptralaiTheophieuxuat = "Cho phép nhập trả lại theo phiếu xuất bán hoặc không";
        public static string mtsChietKhauKhachHang = "26", TenChietKhauKhachHang = "Chiết khấu vào giá hoặc chiết khấu thành tiền";
        public static string mtsDiaChiMayChuWeb = "27", TenDiaChiMayChuWeb = "Địa chỉ máy chủ để đẩy và đồng bôk dữ liệu giữa web và phẩn mềm";
        public static string mtsDonviQuanlySerial = "28", TenDonviQuanlySerial = "Đơn vị kinh doanh có quản lý một số hàng theo số Serial";
        public static string mtsChotsoketoanquakhu = "29", TenChotsoketoanquakhu = "Cho phép chốt sổ kế toán trong quá khứ";
        public static string mtsMadonvidongboma = "30", TenTendonvidongboma = "Mã đơn vị tổng kho";
        public static string mtsMakiemtranhanviendathang = "31", Tenkiemtranhanviendathang = "Kiểm tra dữ liệu nhân viên đặt hàng";
        public static string mtsGiunguyenThongtinPhieuBanbuon = "32", TenGiunguyenThongtinPhieuBanbuon = "Giữ nguyên thông tin bán buôn khi tạo phiếu mới";
        public static string mtsPTNXTongkho = "33", TenPTNXTongkho = "Mã ptnx tổng kho xuất cho đơn vị";
        public static string mtsKHDonvoitrentongkho = "34", TenKHDonvitrentongkho = "Mã khách hàng của đơn vị trên tổng kho";
        public static string mtsCanhbaoton = "35", TenCanhbaoton = "Hiển thị cảnh báo tồn khi đang nhập";
        public static string mtsHientonbanle = "36", Tenhientonbanle = "Hiển thị tồn kho trong bán lẻ";
        public static string mtsDonviNhieuKhoban = "37", TenDonviNhieuKhoban = "Xác định 1 đơn vị có nhiều kho bán lẻ";
        public static string mtsNhapXuatTrungMa = "38", TenNhapXuatTrungMa = "Cho phép nhập xuất trùng mã trên cùng phiếu nhập xuất";
        public static string mtsKieuCtuketoan = "39", TenKieuCtuketoan = "Kiểu mã phiều thu phiếu chi";
        public static string mtsResetDiemTichLuy = "40", TenResetDiemTichLuy = "Cho phép cập nhật điểm tích lũy của khách hàng về =0 khi nhận thưởng";
        public static string mtsHienthiFormKhaibaoKh = "41", TenHienthiFormKhaibaoKh = "Hiển thị Form khai báo thông tin khách hàng tại màn hình bán lẻ";
        public static string mtsCachQuyDoiDiem = "42", TenCachQuyDoiDiem = "Cách quy đổi điểm tích lũy sang tiền";
        public static string mtsLoaiFormTraLai = "43", TenLoaiFormTraLai = "Cài đặt form nhập tiền thanh toán tại màn hình thu ngân";
        public static string mtsHachtoannhieudoituong = "44", TenHachtoannhieudoituong = "Hạch toán nhiều đối tượng";
        public static string mtsTimkiemvattudonle = "45", TenTimkiemvattudonle = "Tìm kiếm vật tư nhập mua xuất bán đơn vật tư";
        public static string mtsTralaikobatbuocnhanvien = "46", TenTralaikobatbuocnhanvien = "Trả lại không bắt buộc nhân viên";
        public static string mtsDiachiwebbanhangPHP = "47", TenDiachiwebbanhangPHP = "Địa chỉ web bán hàng PHP";
        public static string mtsEmaildongbohangPHP = "48", TenEmaildongbohangPHP = "Email đồng bộ dữ liệu web bán hàng PHP";
        public static string mtsCompany_id = "49", TenCompany_id = "ID công ty của web bán hàng PHP";
        public static string mtsAPIkey = "50", TenAPIkey = "API key công ty của web ban hàng PHP";
        public static string mtsDongbotrangthaiwebphp = "51", TenDongbotrangthaiwebphp = "Update lại trạng thái đơn hàng web ban hàng PHP";
        public static string mtsDonviThungle = "52", TenDonviThungle = "Xác định đơn vị có đơn vị lớn để số lẻ";
        public static string mtsCongcom = "53", TenCongcom = "Cổng kết lối cân điện tử";
        public static string mtsThongbaongayps = "54", TenThongbaongayps = "Thống báo khác biệt ngày phát sinh và ngày hiện tại";
        public static string mtsFillBarcode = "55", TenFillBarcode = "Tìm kiếm mã theo 6 ký tự cuối của barcode (tại màn hình bán lẻ)";
        public static string mtsKMBanbuonTaiBanLe = "56", TenKMBanbuonTaiBanLe = "Cho phép có áp dụng các chức năng khuyến mại bán lẻ cho bán buôn lại cửa sổ bán lẻ không";
        public static string mtsDuongdanmaychamcong = "57", TenDuongdanmaychamcong = "Đường dẫn kết nối dữ liệu máy chấm công";
        public static string mtsKhuyenmaitheomax = "58", TenKhuyenmaitheomax = "Khuyến mại theo 1 một loại chương trình";
        public static string mtsInphieubatbuocluuthuc = "59", TenInphieubatbuocluuthuc = "In phiếu chỉ in trên phiếu lưu thực";
        public static string mtsChucnangxacnhannguoidung = "60", TenChucnangxacnhannguoidung = "Chức năng xác nhận người dùng";
        public static string mtsDaygiabanlelenweb = "61", Daygiabanlelenweb = "Đẩy giá bán lẻ lên web";
        public static string mtsKieumakh = "62", Tenkieumakhachhang = "Ký tự đầu của mã khách hàng";
        public static string mtsNhomptnxtinhgiavon = "63", TenNhomptnxtinhgiavon = "Khai báo nhóm phương thức nhập xuất làm thay đổi giá vốn";
        public static string mtsPhuongphaptinhgiavon = "64", TenPhuongphaptinhgiavon = "Khai báo phương pháp tính giá vốn (Theo kho hoặc theo đơn vị)";
        public static string mtsloicamon = "65", Tenloicamon = "Lời cảm ơn trên hóa đơn bán lẻ";
        public static string mtsboquatrangthaidathanhtoan = "66", Tenboquatrangthaidathanhtoan = "Bỏ qua phiếu đã thanh toán";
        public static string mtsthongbaohangthieuton = "67", Tenthongbaohangthieuton = "Thông báo hàng thiếu tồn";
        public static string mtsKhongtaoMahangTudong = "68", TenKhongtaoMahangTudong = "Không tạo mã hàng hóa tự động theo mã ngành hàng";
        public static string mtsMakttudong = "69", TenMakttudong = "Mã phiếu kế toán tạo tự động từ phiếu xuất bán";
        public static string mtsMaphieuthu = "70", TenMaphieuthu = "Mã phiếu thu tạo tự động từ phiếu xuất bán";
        public static string mtsDinhdangtyle = "71", TenDinhdangtyle = "Định dạng tỷ lệ %";
        public static string mtsDinhdangtienngoaite = "72", TenDinhdangtienngoaite = "Định dạng số tiền ngoại tệ";
        public static string mtsSuaNgayhachtoan = "73", TenSuaNgayhachtoan = "Sửa ngày hạch toán trên các phiếu nhập xuất";
        public static string mtsKyhieuHoadon = "74", TenKyhieuHoadon = "Ký hiệu hóa đơn GTGT";
        public static string mtsKoSuatenViettat = "75", TenKoSuatenViettat = "Không sửa tên viết tắt tự động theo tên đầy đủ";
        public static string mtsMagdBanleTutang = "76", TenMagdBanleTutang = "Mã giao dịch bán lẻ tăng theo thứ tự";
        public static string mtsMasuanhangiabansp = "77", TenMasuanhangiabansp = "Cho phép sửa giá bán sản phẩm khi đã lưu thực";
        public static string mtsGiabanTheokho = "78", TenGiabanTheokho = "Cài đặt giá bán lẻ theo kho";
        public static string mtsDaygiabantheogiatriquydoi = "79", Tengiabantheogiatriquydoi = "Đẩy giá bán sản phẩm lên web theo giá quy đổi";
        public static string mtsNhomhangmacdinh = "80", TenNhomhangmacdinh = "Khai báo mã nhóm hàng mặc định khi tạo nhanh mặt hàng";
        public static string mtsTylelaimisa = "81", TenTylelaimisa = "Khai báo tỷ lệ lãi xuất file đẩy misa";
        public static string mtsChophepsuadongiabanbuonnpp = "82", TenChophepsuadongiabanbuonnpp = "Cho phép sưa giá bán trên giao diện xuất bán phân phối";
        public static string mtsDinhdangsoluongle = "83", TenDinhdangsoluongle = "Định dạng số lượng có phần thập phân";
        public static string mtsDinhdangsotienle = "84", TenDinhdangsotienle = "Định dạng số tiền có phần thập phân";
        public static string mtsCaidatSophieuDC = "85", TenCaidatSophieuDC = "Quy định số phiếu điều chuyển giữa các kho xuất khác nhau";
        public static string mtsCheckTrungten = "86", TenCheckTrungten = "Kiểm tra trùng tên sản phẩm khi tạo mã";
        public static string mtsMadonPhuleMasan = "87", TenDonPhuleMasan = "Mã đơn phủ lẻ của nhãn hàng Masan";
        #endregion
        internal static IEnumerable<T> ConvertDataTable<T>(DataTable dt)
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(JsonConvert.SerializeObject(dt)); ;
        }

        internal static List<T> ConvertDataTableToList<T>(DataTable dt)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(dt)); ;
        }

        //public static string GetUrlFromText(string text)
        //{
        //    text = System.Net.WebUtility.UrlEncode(text);
        //    return text.ToLowerInvariant();
        //}

        public static string GetUrlFromText(string text)
        {
            text = RemoveUnicode(text).Replace(' ', '-');
            //string str = text.Replace(' ', '_');
            //str = System.Net.WebUtility.UrlEncode(str);
            return text.ToLowerInvariant();
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                            "đ",
                                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                            "í","ì","ỉ","ĩ","ị",
                                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                            "ý","ỳ","ỷ","ỹ","ỵ","+","*","/","\\"," ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                            "d",
                                            "e","e","e","e","e","e","e","e","e","e","e",
                                            "i","i","i","i","i",
                                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                            "u","u","u","u","u","u","u","u","u","u","u",
                                            "y","y","y","y","y","","","","","",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        #region Mã hóa mật khẩu
        static private DatSymmetric m_symmetric = new DatSymmetric();
        public static string EncryptSvc(String strKey, String strData)//mã hóa mật khẩu
        {
            return m_symmetric.EncryptData(strKey, strData);
        }

        public static string DecryptSvc(String strKey, String strData)//Giải mã mật khâu
        {
            return m_symmetric.DecryptData(strKey, strData);
        }
        #endregion

        public static string GET_MATUDONG(string Ten, string Chucnang, string Loai, string MADONVI, bool isOK, string MatruocRoot)
        {
            string to_Return = "";
            DataTable DT_Collection = DB.GetDataKey(MADONVI, Chucnang, Loai);
            if (DT_Collection == null || DT_Collection.Rows.Count == 0)
            {
                if (MADONVI.Length >= 2)
                {
                    MatruocRoot = MatruocRoot + MADONVI.Substring(MADONVI.Length - 2, 2);
                }
                else
                {
                    MatruocRoot = MatruocRoot + MADONVI;
                }
                if (isOK) DB.InsertCapmatudong(1, MADONVI, Chucnang, Ten, 6, 1, 1, MatruocRoot, "", Loai);
                to_Return = MatruocRoot + "000001";
                return to_Return;
            }
            int Sotutang = 0; int Sokytu = 0;
            string Matruoc = "", Masau = "";
            int.TryParse(DT_Collection.Rows[0]["Sotutang"].ToString(), out Sotutang);
            int.TryParse(DT_Collection.Rows[0]["Sokytu"].ToString(), out Sokytu);
            Matruoc = DT_Collection.Rows[0]["Matruoc"].ToString();
            Masau = DT_Collection.Rows[0]["Masau"].ToString();
            Sotutang = Sotutang + 1;
            int index = Sotutang.ToString().Length;
            for (int i = 0; i <= Sokytu; i++)
            {
                if (i > index)
                {
                    to_Return += "0";
                }
            }
            if (isOK)
            {
                DB.UpdateSotutang(Sotutang, MADONVI, Chucnang, Loai);
            }
            return Matruoc + to_Return + Sotutang.ToString() + Masau;
        }
    }
}
