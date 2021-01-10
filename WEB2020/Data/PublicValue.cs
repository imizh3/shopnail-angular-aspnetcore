using System;
using System.Data;

namespace WEB2020.Data
{
    public class PublicValue
    {
        public static DateTime ngayPhatSinh;
        public static DateTime ngayKhoasoKetoan;
        public static string thongbaohangthieuton = "0";
        public static string returnvalue = "";
        public static string returnvalueName = "";
        public static string ErrorDeleteForeignKey = "The DELETE statement conflicted with the REFERENCE constraint";
        public static string MessageErrorDeleteForeignKey = "Dữ liệu đã được sử dụng trong hệ thống bạn không thể xóa";
        /// <summary>
        /// Khai báo columns tính chất tài khoản
        /// </summary>
        public static string Tinhchat = "Tinhchat";
        public static string Tentinhchat = "TenTinhchat";
        public static string TrangthaiGiaodich = "TrangthaiGiaodich";
        public static string TenTrangthaiGiaodich = "TenTrangthaiGiaodich";
        public static string Mauchuan = "Mauchuan";
        public static string TenMauchuan = "Mẫu chuẩn";
        public static string MauNgoaite = "Maungoaite";
        public static string TenMauNgoaite = "Mẫu ngoại tệ";
        public static string Trangthaikhuyenmai = "TrangthaiKhuyenmaij";
        public static string TenTrangthaiKhuyenmai = "TenTrangthaiKhuyenmai";
        public static string Kieuchungtu = "Kieuchungtu";
        public static string Tenkieuchungtu = "Tenkieuchungtu";
        public static string Loaichungtu = "Loaichungtu";
        public static string Tenloaichungtu = "Tenloaichungtu";
        public static string Thoigianbaohang = "Thoigianbaohanh";
        public static string Tenthoigianbaohang = "Tenthoigianbaohang";
        public static string Sothung = "Sothung";
        //khai báo columns tình trạng thực hiện 
        public static string TinhtrangThuchien = "TinhtrangThuchien";
        public static string TenTinhtrangThuchien = "TenTinhtrangThuchien";

        public static string Thuchikhac = "TCK";
        public static string Thuchitheogiaodich = "TCTGD";
        public static string Thuchitheodongop = "TCTDG";
        public static string ThuchitheogiaodichNDT = "TCNDT";
        public static string Baonobaocokhac = "BNCK";
        public static string Baonobaocotheogiaodich = "BNCTGD";
        public static string Phieudoitruchungtu = "DTCT";
        public static string Phieubutrucongno = "BTCN";
        public static string PhieubutrucongnoNDT = "BTCNNDT";

        public static string foderOffline = "C:\\Temp";

        public static string Madanhmucvthh = "Madanhmucvthh";
        public static string Tendanhmucvthh = "Tendanhmucvthh";

        public static string Giatri = "Giatri";
        public static string Ten = "Ten";
        public static string maThu = "maThu";
        public static string tenThu = "tenThu";

        public static string ct_Sotien = "Sotien";
        public static string ct_Sotiennt = "Sotiennt";
        public static string maThemmoi = "";

        public enum LOAIHANG { TSCD = 1, CCDC = 2, CPNH = 3, CPDH = 4 };

        public enum GOPMA { GOP = 1, TACH = 5, GIA = 10 };

        #region Các biến trạng thái Thêm,Sửa,Load
        public static string SukienThemMoi = "ADD";
        public static string SukienSua = "EDIT";
        public static string SukienLoad = "LOAD";
        public static string SukienLuutam = "LUUTAM";
        public static string SukienLuuthuc = "LUUTHUC";
        public static string SukienXoa = "DELETE";
        public static string SukienCoppy = "COPPY";
        #endregion
        #region Biến định dạng số
        public static string dinhdangsotien = "N2";
        public static string dinhdangsotiennt = "N2";
        public static string dinhdangsosoluong = "N0";
        public static string dinhdangsosoluongle = "N2";
        public static string dinhdangsotienle = "N2";
        public static string dinhdangtyle = "N2";
        public static int lamTronDenChuso = 6;
        public string Dinhdangsotien
        {
            get { return PublicValue.dinhdangsotien; }
            set { PublicValue.dinhdangsotien = value; }
        }
        public string Dinhdangsosoluong
        {
            get { return PublicValue.dinhdangsosoluong; }
            set { PublicValue.dinhdangsosoluong = value; }
        }

        public string Dinhdangtyle
        {
            get { return PublicValue.dinhdangtyle; }
            set { PublicValue.dinhdangtyle = value; }
        }
        public int LamTronDenChuso
        {
            get { return lamTronDenChuso; }
            set { lamTronDenChuso = value; }
        }
        #endregion
        #region Khởi tạo các biến toàn cục
        public DateTime NgayPhatSinh
        {
            get { return ngayPhatSinh; }
            set { ngayPhatSinh = value; }
        }

        private static string XNTTABLENAME = "";
        public static string XNT_TABLENAME(DateTime ngayHachtoan)
        {
            string ngay = "", thang = "", nam = "";
            ngay = ngayHachtoan.Day.ToString(); if (ngayHachtoan.Day < 10) ngay = "0" + ngayHachtoan.Day.ToString();
            thang = ngayHachtoan.Month.ToString(); if (ngayHachtoan.Month < 10) thang = "0" + ngayHachtoan.Month.ToString();
            nam = ngayHachtoan.Year.ToString();
            XNTTABLENAME = "XNT_" + ngay + thang + nam;
            return XNTTABLENAME;
        }

        public static String maNguoiTao;
        public String MaNguoiTao
        {
            get { return PublicValue.maNguoiTao; }
            set { PublicValue.maNguoiTao = value; }
        }

        public static string tenNguoiTao = "";
        public string TenNguoiTao
        {
            get { return PublicValue.tenNguoiTao; }
            set { PublicValue.tenNguoiTao = value; }
        }

        public static string tenDangnhap = "";
        public string TenDangnhap
        {
            get { return PublicValue.tenDangnhap; }
            set { PublicValue.tenDangnhap = value; }
        }

        public static string trangThaiHTKT = "0";
        public string TrangThaiHTKT
        {
            get { return PublicValue.trangThaiHTKT; }
            set { PublicValue.trangThaiHTKT = value; }
        }
        public static string maNhanVienCongNo = "";
        public string MaNhanVienCongNo
        {
            get { return maNhanVienCongNo; }
            set { maNhanVienCongNo = value; }
        }
        public static string trangThaiQuydoiThungLe = "0";
        public string TrangThaiQuydoiThungLe
        {
            get { return PublicValue.trangThaiQuydoiThungLe; }
            set { PublicValue.trangThaiQuydoiThungLe = value; }
        }
        public static string Itemcode = "Macandientu";

        public static string canhbaongayps = "0";
        public string Canhbaongayps
        {
            get { return PublicValue.canhbaongayps; }
            set { PublicValue.canhbaongayps = value; }
        }
        #endregion
        #region Khai báo trạng thái phiếu (lưu tam, lưu thực)
        public static int Luutam = 1;
        public static int Luuthuc = 10;

        public static int KMthuong = 1;
        public static int KMtrathuong = 10;


        private static DataTable dtMaubaocao;
        private static DataTable dtBangkeThueGtgt;
        public static DataTable DT_LoaiBangkeThueGtgt()
        {
            dtBangkeThueGtgt = new DataTable();
            if (dtBangkeThueGtgt.Columns.Contains(PublicValue.Ten) == false) dtBangkeThueGtgt.Columns.Add(PublicValue.Ten, typeof(string));
            if (dtBangkeThueGtgt.Columns.Contains(PublicValue.Giatri) == false) dtBangkeThueGtgt.Columns.Add(PublicValue.Giatri, typeof(string));
            DataRow rAdd = dtBangkeThueGtgt.NewRow();
            rAdd[PublicValue.Ten] = "Bảng kê thuế Gtgt đầu vào";
            rAdd[PublicValue.Giatri] = PublicValue.BangkeDauvao;
            dtBangkeThueGtgt.Rows.Add(rAdd);

            rAdd = dtBangkeThueGtgt.NewRow();
            rAdd[PublicValue.Ten] = "Bảng kê thuế Gtgt đầu ra";
            rAdd[PublicValue.Giatri] = PublicValue.BangkeDaura;
            dtBangkeThueGtgt.Rows.Add(rAdd);

            return dtBangkeThueGtgt;
        }
        public static DataTable DT_Maubaocao()
        {
            dtMaubaocao = new DataTable();

            if (dtMaubaocao.Columns.Contains(PublicValue.Ten) == false) dtMaubaocao.Columns.Add(PublicValue.Ten, typeof(string));
            if (dtMaubaocao.Columns.Contains(PublicValue.Giatri) == false) dtMaubaocao.Columns.Add(PublicValue.Giatri, typeof(string));
            DataRow rAdd = dtMaubaocao.NewRow();
            rAdd[PublicValue.Giatri] = Mauchuan;
            rAdd[PublicValue.Ten] = TenMauchuan;
            dtMaubaocao.Rows.Add(rAdd);

            rAdd = dtMaubaocao.NewRow();
            rAdd[PublicValue.Giatri] = MauNgoaite;
            rAdd[PublicValue.Ten] = TenMauNgoaite;
            dtMaubaocao.Rows.Add(rAdd);

            return dtMaubaocao;
        }
        private static DataTable dtTinhtrangThuchien;
        public static DataTable DT_TinhtrangThuchien()
        {
            dtTinhtrangThuchien = new DataTable();

            if (dtTinhtrangThuchien.Columns.Contains(PublicValue.Giatri) == false) dtTinhtrangThuchien.Columns.Add(PublicValue.Giatri, typeof(int));
            if (dtTinhtrangThuchien.Columns.Contains(PublicValue.Ten) == false) dtTinhtrangThuchien.Columns.Add(PublicValue.Ten, typeof(string));
            DataRow rAdd = dtTinhtrangThuchien.NewRow();
            rAdd[PublicValue.Giatri] = 1;
            rAdd[PublicValue.Ten] = "Đang thực hiện";
            dtTinhtrangThuchien.Rows.Add(rAdd);

            rAdd = dtTinhtrangThuchien.NewRow();
            rAdd[PublicValue.Giatri] = 2;
            rAdd[PublicValue.Ten] = "Tạm dừng";
            dtTinhtrangThuchien.Rows.Add(rAdd);

            rAdd = dtTinhtrangThuchien.NewRow();
            rAdd[PublicValue.Giatri] = 3;
            rAdd[PublicValue.Ten] = "Dừng";
            dtTinhtrangThuchien.Rows.Add(rAdd);

            rAdd = dtTinhtrangThuchien.NewRow();
            rAdd[PublicValue.Giatri] = 10;
            rAdd[PublicValue.Ten] = "Hoàn thành";
            dtTinhtrangThuchien.Rows.Add(rAdd);

            return dtTinhtrangThuchien;
        }
        private static DataTable dtKieuchungtu;
        public static DataTable DT_Kieuchungtu()
        {
            dtKieuchungtu = new DataTable();

            if (dtTinhchatNhapXuat.Columns.Contains(Kieuchungtu) == false) dtKieuchungtu.Columns.Add(Kieuchungtu, typeof(string));
            if (dtTinhchatNhapXuat.Columns.Contains(Tenkieuchungtu) == false) dtKieuchungtu.Columns.Add(Tenkieuchungtu, typeof(string));

            DataRow rALL = dtKieuchungtu.NewRow();
            rALL[Kieuchungtu] = "ALL";
            rALL[Tenkieuchungtu] = "Tất cả";
            dtKieuchungtu.Rows.Add(rALL);

            DataRow rLuutam = dtKieuchungtu.NewRow();
            rLuutam[Kieuchungtu] = PublicValue.MA_CT_PTHU;
            rLuutam[Tenkieuchungtu] = "Phiếu thu";
            dtKieuchungtu.Rows.Add(rLuutam);

            DataRow rLuuthuc = dtKieuchungtu.NewRow();
            rLuuthuc[Kieuchungtu] = PublicValue.MA_CT_PCHI;
            rLuuthuc[Tenkieuchungtu] = "Phiếu chi";
            dtKieuchungtu.Rows.Add(rLuuthuc);

            return dtKieuchungtu;
        }

        private static DataTable dtLoaichungtu;
        public static DataTable DT_Loaichungtu()
        {
            dtLoaichungtu = new DataTable();

            if (dtTinhchatNhapXuat.Columns.Contains(Loaichungtu) == false) dtLoaichungtu.Columns.Add(Loaichungtu, typeof(string));
            if (dtTinhchatNhapXuat.Columns.Contains(Tenloaichungtu) == false) dtLoaichungtu.Columns.Add(Tenloaichungtu, typeof(string));

            DataRow rALL = dtLoaichungtu.NewRow();
            rALL[Loaichungtu] = "ALL";
            rALL[Tenloaichungtu] = "Tất cả";
            dtLoaichungtu.Rows.Add(rALL);

            DataRow rLuutam = dtLoaichungtu.NewRow();
            rLuutam[Loaichungtu] = PublicValue.Thuchikhac;
            rLuutam[Tenloaichungtu] = "Khác";
            dtLoaichungtu.Rows.Add(rLuutam);

            DataRow rLuuthuc = dtLoaichungtu.NewRow();
            rLuuthuc[Loaichungtu] = PublicValue.Thuchitheogiaodich;
            rLuuthuc[Tenloaichungtu] = "Theo giao dịch";
            dtLoaichungtu.Rows.Add(rLuuthuc);

            DataRow rThuchinhieudoituong = dtLoaichungtu.NewRow();
            rLuuthuc[Loaichungtu] = PublicValue.ThuchitheogiaodichNDT;
            rLuuthuc[Tenloaichungtu] = "Theo giao dịch nhiều đối tượng";
            dtLoaichungtu.Rows.Add(rThuchinhieudoituong);

            DataRow rthuchitheodg = dtLoaichungtu.NewRow();
            rthuchitheodg[Loaichungtu] = PublicValue.Thuchitheodongop;
            rthuchitheodg[Tenloaichungtu] = "Theo đơn gộp";
            dtLoaichungtu.Rows.Add(rthuchitheodg);

            return dtLoaichungtu;
        }

        private static DataTable dtLoaichungtuBNBC;
        public static DataTable DT_LoaichungtuBNBC()
        {
            dtLoaichungtuBNBC = new DataTable();

            if (dtTinhchatNhapXuat.Columns.Contains(Loaichungtu) == false) dtLoaichungtuBNBC.Columns.Add(Loaichungtu, typeof(string));
            if (dtTinhchatNhapXuat.Columns.Contains(Tenloaichungtu) == false) dtLoaichungtuBNBC.Columns.Add(Tenloaichungtu, typeof(string));

            DataRow rALL = dtLoaichungtuBNBC.NewRow();
            rALL[Loaichungtu] = "ALL";
            rALL[Tenloaichungtu] = "Tất cả";
            dtLoaichungtuBNBC.Rows.Add(rALL);

            DataRow rLuutam = dtLoaichungtuBNBC.NewRow();
            rLuutam[Loaichungtu] = PublicValue.Baonobaocokhac;
            rLuutam[Tenloaichungtu] = "Khác";
            dtLoaichungtuBNBC.Rows.Add(rLuutam);

            DataRow rLuuthuc = dtLoaichungtuBNBC.NewRow();
            rLuuthuc[Loaichungtu] = PublicValue.Baonobaocotheogiaodich;
            rLuuthuc[Tenloaichungtu] = "Theo giao dịch";
            dtLoaichungtuBNBC.Rows.Add(rLuuthuc);

            return dtLoaichungtuBNBC;
        }

        private static DataTable dtKieuchungtubnbc;
        public static DataTable DT_Kieuchungtubnbc()
        {
            dtKieuchungtubnbc = new DataTable();

            if (dtTinhchatNhapXuat.Columns.Contains(Kieuchungtu) == false) dtKieuchungtubnbc.Columns.Add(Kieuchungtu, typeof(string));
            if (dtTinhchatNhapXuat.Columns.Contains(Tenkieuchungtu) == false) dtKieuchungtubnbc.Columns.Add(Tenkieuchungtu, typeof(string));

            DataRow rALL = dtKieuchungtubnbc.NewRow();
            rALL[Kieuchungtu] = "ALL";
            rALL[Tenkieuchungtu] = "Tất cả";
            dtKieuchungtubnbc.Rows.Add(rALL);

            DataRow rLuutam = dtKieuchungtubnbc.NewRow();
            rLuutam[Kieuchungtu] = PublicValue.MA_CT_BAOCO;
            rLuutam[Tenkieuchungtu] = "Phiếu báo có(thu tiền bằng tk ngân hàng)";
            dtKieuchungtubnbc.Rows.Add(rLuutam);

            DataRow rLuuthuc = dtKieuchungtubnbc.NewRow();
            rLuuthuc[Kieuchungtu] = PublicValue.MA_CT_BAONO;
            rLuuthuc[Tenkieuchungtu] = "Phiếu báo nợ(chi tiền bằng tk ngân hàng)";
            dtKieuchungtubnbc.Rows.Add(rLuuthuc);

            return dtKieuchungtubnbc;
        }

        private static DataTable dtTrangthaiThanhtoan;
        private static DataTable dtThoigianbaohang;
        public static DataTable DT_ThoiGianBaoHanh()
        {
            dtThoigianbaohang = new DataTable();

            if (dtThoigianbaohang.Columns.Contains(Thoigianbaohang) == false) dtThoigianbaohang.Columns.Add(Thoigianbaohang, typeof(string));
            if (dtThoigianbaohang.Columns.Contains(Tenthoigianbaohang) == false) dtThoigianbaohang.Columns.Add(Tenthoigianbaohang, typeof(string));
            DataRow rNgay = dtThoigianbaohang.NewRow();
            rNgay[Thoigianbaohang] = "Ngày";
            dtThoigianbaohang.Rows.Add(rNgay);

            DataRow rThang = dtThoigianbaohang.NewRow();
            rThang[Thoigianbaohang] = "Tháng";
            dtThoigianbaohang.Rows.Add(rThang);

            DataRow rNam = dtThoigianbaohang.NewRow();
            rNam[Thoigianbaohang] = "Năm";
            dtThoigianbaohang.Rows.Add(rNam);


            return dtThoigianbaohang;
        }

        #endregion
        #region Khai báo trạng thái khuyến mại (đang hoạt động, đã dừng hoạt động)
        public static int Hoatdong = 10;
        public static int Khonghoatdong = 1;
        private static DataTable dtTrangthaiKhuyenmai;
        public static DataTable DT_TrangthaiKhuyenmai()
        {
            dtTrangthaiKhuyenmai = new DataTable();
            string tenHoatdong = "CT đang hoạt động";
            string tenKhonghoatdong = "CT ngừng hoạt động";

            if (dtTrangthaiKhuyenmai.Columns.Contains(Trangthaikhuyenmai) == false) dtTrangthaiKhuyenmai.Columns.Add(Trangthaikhuyenmai, typeof(int));
            if (dtTrangthaiKhuyenmai.Columns.Contains(TenTrangthaiKhuyenmai) == false) dtTrangthaiKhuyenmai.Columns.Add(TenTrangthaiKhuyenmai, typeof(string));
            DataRow rLuutam = dtTrangthaiKhuyenmai.NewRow();
            rLuutam[Trangthaikhuyenmai] = 1;
            rLuutam[TenTrangthaiKhuyenmai] = tenKhonghoatdong;
            dtTrangthaiKhuyenmai.Rows.Add(rLuutam);

            DataRow rLuuthuc = dtTrangthaiKhuyenmai.NewRow();
            rLuuthuc[Trangthaikhuyenmai] = 10;
            rLuuthuc[TenTrangthaiKhuyenmai] = tenHoatdong;
            dtTrangthaiKhuyenmai.Rows.Add(rLuuthuc);

            return dtTrangthaiKhuyenmai;
        }
        #endregion
        #region Biến tham số xác định cho phép in từ phiếu lưu tạm hay không
        public static string ChophepIntemPhieuLuutam = "0";
        #endregion
        #region Biến tham số cho phép cập nhật giá bán từ phiếu nhập vào danh mục mặt hàng (mặc định là có)
        public static string CapnhatGiabanTuPhieuNhap = "1";
        #endregion
        #region Biến tham số nhập xuất theo kho quy định
        public static string NhapXuatKhoQuyDinh = "0";
        #endregion
        #region Định nghĩa các quyền trong bán lẻ
        public static string QuyenNhapSoluong = "Nhapsoluong";
        public static string QuyenNhapMahang = "NhapMahang";
        public static string QuyenNhapGia = "NhapGia";
        public static string QuyenNhapTileChietkhau = "NhapTileChietkhau";
        public static string QuyenNhapTienhang = "NhapTienhang";
        public static string QuyenTanghang = "TangHang";
        public static string QuyenGiamhang = "GiamHang";
        public static string QuyenKhoiphuc = "KhoiPhuc";
        #endregion
        #region Định nghĩa các quyền trong Giao nhận
        public static string GNQuyenNhapSoluong = "GNNhapsoluong";
        public static string GNQuyenNhapMahang = "GNNhapMahang";
        public static string GNQuyenNhapGia = "GNNhapGia";
        public static string GNQuyenNhapTileChietkhau = "GNNhapTileChietkhau";
        public static string GNQuyenNhapTienhang = "GNNhapTienhang";
        public static string GNQuyenTanghang = "GNTangHang";
        public static string GNQuyenGiamhang = "GNGiamHang";
        public static string GNQuyenKhoiphuc = "GNKhoiPhuc";
        #endregion
        #region Định nghĩa các loại cài đặt giá bán
        public static int KhachangGiabanTheoMathang = 1;
        public static int KhachangGiabanTheoNhomhang = 2;
        public static int KhachangGiabanTheoNganhhang = 3;
        public static int Cktheosanpham = 4;
        public static string LoaiGiabanleMH = "MH";
        public static string LoaiGiabanleBH = "BH";
        #endregion

        #region Biến quy định quã nhận dạng cân điện tử
        public static string maCanDienTu = "";
        #endregion
        #region Biến trừ tồn trực tiếp bán lẻ
        public static string isTrutonBale = "1";
        #endregion
        #region Biến kết nối đến hệ thống cấp mã
        public static string isKetnoiCapma = "0";
        #endregion
        #region Biến địa chỉ máy chủ kết nối cấp mã
        public static string DiachiMaychuCapma = "";

        public static string maDonvidongboma = "";
        #endregion
        #region Loại hóa đơn bán lẻ
        public static int LoaiHoaDon = 1;
        public static string Tieudehoadon = "HÓA ĐƠN BÁN LẺ";
        public static string Loicamon = "Xin Chân thành cảm ơn quý khách";
        #endregion
        #region Biến xác định nhập trả lại theo số phiếu xuất hay không
        public static string NhapTralaiTheoPhieuxuat = "1";
        #endregion
        #region Biến xác định hệ thống có quản lý serial một số mặt hàng
        public static string isQuanlySerial = "0";
        #endregion
        #region Biến xác định hệ thống có giữ nguyên thông tin phiếu xuất buôn khi thêm mới hay không
        public static string isGiunguyenBanbuon = "0";
        #endregion
        #region Biến xác định hệ thống có cho phép nhập xuất trùng mã trên phiếu nhập xuất không
        public static string isNhapXuatTrungMa = "0";
        #endregion
        #region Biến xác đinh in phiếu bắt buộc lưu thực không
        public static string isInPhieuLuuThuc = "0";
        #endregion
        #region Danh mục đồng bộ VTHH
        private static DataTable dtDanhsachdm;
        private static DataTable dtDanhsachdmWeb;
        private static DataTable dtDanhsachthu;
        public static DataTable DT_Danhsachdm()
        {
            dtDanhsachdm = new DataTable();

            if (dtDanhsachdm.Columns.Contains(Madanhmucvthh) == false) dtDanhsachdm.Columns.Add(Madanhmucvthh, typeof(string));
            if (dtDanhsachdm.Columns.Contains(Tendanhmucvthh) == false) dtDanhsachdm.Columns.Add(Tendanhmucvthh, typeof(string));

            DataRow rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "All";
            rLuutam[Tendanhmucvthh] = "Tất cả danh mục";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Nganhhang";
            rLuutam[Tendanhmucvthh] = "Ngành hàng";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Nhomhang";
            rLuutam[Tendanhmucvthh] = "Nhóm hàng";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Donvitinh";
            rLuutam[Tendanhmucvthh] = "Đơn vị tính";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Kehang";
            rLuutam[Tendanhmucvthh] = "Kệ hàng";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Vat";
            rLuutam[Tendanhmucvthh] = "Vat";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Khachhang";
            rLuutam[Tendanhmucvthh] = "nhà cung cấp";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Mathang";
            rLuutam[Tendanhmucvthh] = "Mặt hàng";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "Bohang";
            rLuutam[Tendanhmucvthh] = "Bó hàng";
            dtDanhsachdm.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdm.NewRow();
            rLuutam[Madanhmucvthh] = "DMTK";
            rLuutam[Tendanhmucvthh] = "Tài khoản kế toán";
            dtDanhsachdm.Rows.Add(rLuutam);


            return dtDanhsachdm;
        }
        public static DataTable DT_DanhsachdmWeb()
        {
            dtDanhsachdmWeb = new DataTable();

            if (dtDanhsachdmWeb.Columns.Contains(Madanhmucvthh) == false) dtDanhsachdmWeb.Columns.Add(Madanhmucvthh, typeof(string));
            if (dtDanhsachdmWeb.Columns.Contains(Tendanhmucvthh) == false) dtDanhsachdmWeb.Columns.Add(Tendanhmucvthh, typeof(string));

            DataRow rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "All";
            rLuutam[Tendanhmucvthh] = "Tất cả danh mục";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "Nganhhang";
            rLuutam[Tendanhmucvthh] = "Ngành hàng";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "Nhomhang";
            rLuutam[Tendanhmucvthh] = "Nhóm hàng";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "Mathang";
            rLuutam[Tendanhmucvthh] = "Mặt hàng";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "Khachhang";
            rLuutam[Tendanhmucvthh] = "Khách Hàng";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "Nhanvien";
            rLuutam[Tendanhmucvthh] = "Nhân Viên";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "NhanvienKhachhang";
            rLuutam[Tendanhmucvthh] = "Nhân viên-Khách hàng";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "phanquyennvhh";
            rLuutam[Tendanhmucvthh] = "Phân quyền nhân viên hàng hóa";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            rLuutam = dtDanhsachdmWeb.NewRow();
            rLuutam[Madanhmucvthh] = "khuyenmai";
            rLuutam[Tendanhmucvthh] = "Chương trình khuyến mại";
            dtDanhsachdmWeb.Rows.Add(rLuutam);

            return dtDanhsachdmWeb;
        }

        public static DataTable DT_Danhsachthu()
        {
            dtDanhsachthu = new DataTable();

            if (dtDanhsachthu.Columns.Contains(maThu) == false) dtDanhsachthu.Columns.Add(maThu, typeof(string));
            if (dtDanhsachthu.Columns.Contains(tenThu) == false) dtDanhsachthu.Columns.Add(tenThu, typeof(string));

            DataRow rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Monday";
            rLuutam[tenThu] = "Thứ hai";
            dtDanhsachthu.Rows.Add(rLuutam);

            rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Tuesday";
            rLuutam[tenThu] = "Thứ ba";
            dtDanhsachthu.Rows.Add(rLuutam);

            rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Wednesday";
            rLuutam[tenThu] = "Thứ tư";
            dtDanhsachthu.Rows.Add(rLuutam);

            rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Thursday";
            rLuutam[tenThu] = "Thứ năm";
            dtDanhsachthu.Rows.Add(rLuutam);

            rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Friday";
            rLuutam[tenThu] = "Thứ sáu";
            dtDanhsachthu.Rows.Add(rLuutam);

            rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Saturday";
            rLuutam[tenThu] = "Thứ bẩy";
            dtDanhsachthu.Rows.Add(rLuutam);

            rLuutam = dtDanhsachthu.NewRow();
            rLuutam[maThu] = "Sunday";
            rLuutam[tenThu] = "Chủ nhật";
            dtDanhsachthu.Rows.Add(rLuutam);

            return dtDanhsachthu;
        }
        #endregion
        #region
        public static int ThuChiTienHang = 1;
        public static int ChiPhiVanChuyen = 2;
        public static int ChietkhauThanhToan = 3;
        public static int DoiTruChungTu = 4;
        public static int Chitienckthung = 5;
        public static int ChitiencktrathuongNV = 6;
        public static int ChitiencktrathuongKH = 7;
        public static int ChitienckDaily = 8;
        public static int ChitienckNAM = 9;
        #endregion
        public static string maDonVi;
        public static string SuaNgayhachtoan = "0";
        public static int Kiemtranhanviendathang = 0;
        public static string KoSuatenViettat = "";
        public static string IsMagdbanleTutang = "";
        public int _Kiemtranhanviendathang
        {
            get { return PublicValue.Kiemtranhanviendathang; }
            set { PublicValue.Kiemtranhanviendathang = value; }
        }

        private static bool _Xacnhannguoidung = false;

        public static bool isXacnhannguoidung
        {
            get { return _Xacnhannguoidung; }
            set { _Xacnhannguoidung = value; }
        }
        public string MaDonVi
        {
            get { return PublicValue.maDonVi; }
            set { PublicValue.maDonVi = value; }
        }
        public static string tenDonVi = "";
        public static string Masothue = "";
        public static string diaChiDonVi = "";
        public static string dienThoaiDonVi = "";
        public static string Giamdoc = "";
        public static string Ketoantruong = "";
        public static string Nguoibanhang = "";
        public static string Nguoikybieu = "";
        public static string KyhieuHoadon = "";
        public static string Mausohoadon = "";
        public static string DIACHI_MAYCHUDONGBO = "";
        public static string SophieuDieuchuyen = "";
        public static string CheckTrungTendaydu = "1";
        public static string kieusodu = "SD";
        public static string kieuchotso = "CS";

        public static string Lang = "";

        public static String maNhomquyen;
        public String MaNhomquyen
        {
            get { return PublicValue.maNhomquyen; }
            set { PublicValue.maNhomquyen = value; }
        }

        public static DataTable dtMathang;
        public DataTable DtMathang
        {
            get { return PublicValue.dtMathang; }
            set { PublicValue.dtMathang = value; }
        }

        public static DataTable dtBarcode;

        public DataTable DtBarcode
        {
            get { return PublicValue.dtBarcode; }
            set { PublicValue.dtBarcode = value; }
        }

        public static string tenMayChu = "";

        public static string maNganhhangphanquyen = "";
        public static string maNhomhangphanquyen = "";
        public static string GiabanleTheokho = "";
        #region Biến kiểm tra trạng thái online - offline
        public static bool offLine;

        public bool OffLine
        {
            get { return offLine; }
            set { offLine = value; }
        }
        #endregion
        #region Danh mục nhóm phương thức nhập xuất

        public static string N_MUA = "N_MUA";
        public static string N_KHAU = "N_KHAU";
        public static string N_DIEUCHINH = "N_DIEUCHINH";
        public static string N_BANBUONTRALAI = "N_BANBUONTRALAI";
        public static string N_KHAC = "N_KHAC";
        public static string N_NOIBO = "N_NOIBO";
        public static string N_DICHVU = "N_DICHVU";
        public static string N_THANHPHAM = "N_THANHPHAM";
        public static string N_NLDDANG = "N_NLDDANG";
        public static string N_TRALAI = "N_TRALAI";
        public static string DH_DATHANG = "DH_NCC";
        public static string N_KIEMKE = "N_KIEMKE";
        public static string SX_DHSANXUAT = "SX_DHSX";
        public static string SX_LENHSANXUAT = "SX_LENHSX";
        public static string DH_KHDATHANG = "DH_KH";

        public static string X_BANBUON = "X_BANBUON";
        public static string X_BANLE = "X_BANLE";
        public static string X_BAN_HA = "X_BAN_HA";
        public static string X_NOIBO = "X_NOIBO";
        public static string X_TAICHE = "X_TAICHE";
        public static string X_CHUYENKHO = "X_CHUYENKHO";
        public static string X_SUDUNG = "X_SUDUNG";
        public static string X_DIEUCHINH = "X_DIEUCHINH";
        public static string X_TRALAI = "X_TRALAI";
        public static string X_DICHDANH = "X_DICHDANH";
        public static string X_KHAC = "X_KHAC";
        public static string X_SANXUAT = "X_SANXUAT";
        public static string X_DICHVU = "X_DICHVU";
        public static string X_KIEMKE = "X_KIEMKE";
        public static string X_HUY = "X_HUY";
        public static string GIAONHAN = "GIAONHAN";
        public static string DOITRA = "DOITRA";

        #endregion
        #region Danh mục loại kho
        public static string maLoaiKhonhap = "01";
        public static string maLoaiKhobanle = "02";
        public static string maLoaiKhobanbuon = "03";
        public static string maLoaiKhoxuathuy = "04";
        public static string maLoaiKhoxuattra = "05";
        public static string maLoaiKhokhuyenmai = "06";
        public static string maLoaiKhohangam = "07";
        #endregion

        #region Các biến liên quan trong công thức tính tiền hàng
        public static string TIEN_CK = "TIENCK";
        public static string TIEN_HANG = "TIENHANG";
        public static string TIEN_VAT = "TIENVAT";
        public static string TIEN_KM = "TIENKM";
        public static string TIEN_CPVC = "TIENCPVC";
        public static string TIEN_CPKHAC = "TIENCPKHAC";
        public static string TIEN_THUE_NK = "TIENTHUENK";
        #endregion

        #region Danh mục loại chứng từ
        public static string MA_CT_PCHI = "PC";
        public static string MA_CT_PCHI_HA = "PCHA";
        public static string MA_CT_PTHU = "PT";
        public static string MA_CT_PKT = "PKT";
        public static string MA_CT_BAOCO = "BCO";
        public static string MA_CT_BAONO = "BNO";
        public static string MA_CT_BUTRU = "PBT";
        public static string MA_CT_KETCHUYEN = "KC";
        public static string MA_CT_DOITRU = "PDC";
        public static string MA_CT_DOITRUNHIEUDOITUONG = "PBTNDT";
        public static string MA_CT_CHUYENTIENNOIBO = "CT";

        #endregion

        #region Danh mục loại khách hàng
        public static string MA_KH_CC = "KHNCC";
        public static string MA_KH = "KH";
        public static string MA_NCC = "NCC";
        public static string MA_NV = "NV";
        public static string TH_NVKH = "KHNV";
        #endregion

        #region Danh mục tính chất tài khoản
        private static DataTable dtTinhchatTaikhoan = new DataTable();
        private static DataTable dtTaikhoanChacon = new DataTable();
        public static int maTinhchatDuno = 1;
        public static int maTinhchatDuco = 2;
        public static int maTinhchatLuongtinh = 3;
        public static int maTinhchatKhongcosodu = 4;
        public static int maTaikhoansocai = 1;
        public static int maTaikhoansocaichitiet = 2;
        public static int maTaikhoanchitiet = 3;

        public static DataTable DT_TinhchatTaikhoan()
        {
            dtTinhchatTaikhoan = new DataTable();
            string tenTinhchatDuno = "Dư nợ";
            string tenTinhchatDuco = "Dư có";
            string tenTinhchatLuongtinh = "Lưỡng tính";
            string tenTinhchatKhongcosodu = "Không có số dư";

            if (dtTinhchatTaikhoan.Columns.Contains(Tinhchat) == false) dtTinhchatTaikhoan.Columns.Add(Tinhchat, typeof(string));
            if (dtTinhchatTaikhoan.Columns.Contains(Tentinhchat) == false) dtTinhchatTaikhoan.Columns.Add(Tentinhchat, typeof(string));
            DataRow rTinhchat1 = dtTinhchatTaikhoan.NewRow();
            rTinhchat1[Tinhchat] = maTinhchatDuno.ToString();
            rTinhchat1[Tentinhchat] = tenTinhchatDuno.ToString();
            dtTinhchatTaikhoan.Rows.Add(rTinhchat1);

            DataRow rTinhchat2 = dtTinhchatTaikhoan.NewRow();
            rTinhchat2[Tinhchat] = maTinhchatDuco.ToString();
            rTinhchat2[Tentinhchat] = tenTinhchatDuco.ToString();
            dtTinhchatTaikhoan.Rows.Add(rTinhchat2);

            DataRow rTinhchat3 = dtTinhchatTaikhoan.NewRow();
            rTinhchat3[Tinhchat] = maTinhchatLuongtinh.ToString();
            rTinhchat3[Tentinhchat] = tenTinhchatLuongtinh.ToString();
            dtTinhchatTaikhoan.Rows.Add(rTinhchat3);

            DataRow rTinhchat4 = dtTinhchatTaikhoan.NewRow();
            rTinhchat4[Tinhchat] = maTinhchatKhongcosodu.ToString();
            rTinhchat4[Tentinhchat] = tenTinhchatKhongcosodu.ToString();
            dtTinhchatTaikhoan.Rows.Add(rTinhchat4);

            return dtTinhchatTaikhoan;
        }
        public static DataTable DT_Taikhoanchacon()
        {
            dtTaikhoanChacon = new DataTable();
            string tenTaikhoansocai = "Sổ cái";
            string tenTaikhoansocaichitiet = "Sổ cái và chi tiết";
            string tenTaikhoanchitiet = "Chi tiết";

            if (dtTaikhoanChacon.Columns.Contains("Tkchitiet") == false) dtTaikhoanChacon.Columns.Add("Tkchitiet", typeof(string));
            if (dtTaikhoanChacon.Columns.Contains("TenTkchitiet") == false) dtTaikhoanChacon.Columns.Add("TenTkchitiet", typeof(string));
            DataRow rTinhchat1 = dtTaikhoanChacon.NewRow();
            rTinhchat1["Tkchitiet"] = maTaikhoansocai.ToString();
            rTinhchat1["TenTkchitiet"] = tenTaikhoansocai.ToString();
            dtTaikhoanChacon.Rows.Add(rTinhchat1);

            DataRow rTinhchat2 = dtTaikhoanChacon.NewRow();
            rTinhchat2["Tkchitiet"] = maTaikhoansocaichitiet.ToString();
            rTinhchat2["TenTkchitiet"] = tenTaikhoansocaichitiet.ToString();
            dtTaikhoanChacon.Rows.Add(rTinhchat2);

            DataRow rTinhchat3 = dtTaikhoanChacon.NewRow();
            rTinhchat3["Tkchitiet"] = maTaikhoanchitiet.ToString();
            rTinhchat3["TenTkchitiet"] = tenTaikhoanchitiet.ToString();
            dtTaikhoanChacon.Rows.Add(rTinhchat3);

            return dtTaikhoanChacon;
        }
        #endregion

        #region Tính chất nhập xuất
        private static DataTable dtTinhchatNhapXuat = new DataTable();
        public static int maTinhchatNhap = 1;
        public static int maTinhchatXuat = 2;
        public static int maTinhchatKhac = 3;
        public static int maTinhchat_NhapKhoThanhPham = 4;
        public static int maTinhchat_NhapNVLThua = 5;
        public static int maTinhchat_XuatKhoNVL = 6;
        public static int maTinhchat_Lenhxuatkho = 7;
        public static int matinhchat_Nhapkhau = 8;
        public static DataTable DT_TinhchatNhapXuat()
        {
            dtTinhchatNhapXuat = new DataTable();
            string tenTinhchatNhap = "Nhập kho khác";
            string tenTinhchatXuat = "Xuất kho khác";
            string tenTinhchatKhac = "Nhập xuất khác";
            string tenTinhchat_NhapKhoThanhpham = "Nhập kho thành phẩm";
            string tenTinhchat_NhapNVLThua = "Nhập nguyên vật liệu thừa";
            string tenTinhchat_XuatKhoNVL = "Xuất kho nguyên liệu";
            string tenTinhchat_Lenhxuatkho = "Lệnh xuất kho";
            string tenTinhchat_Nhapkhau = "Xuất, Nhập khẩu";

            if (dtTinhchatNhapXuat.Columns.Contains(Tinhchat) == false) dtTinhchatNhapXuat.Columns.Add(Tinhchat, typeof(string));
            if (dtTinhchatNhapXuat.Columns.Contains(Tentinhchat) == false) dtTinhchatNhapXuat.Columns.Add(Tentinhchat, typeof(string));
            DataRow rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchatNhap.ToString();
            rTinhchat[Tentinhchat] = tenTinhchatNhap.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchatXuat.ToString();
            rTinhchat[Tentinhchat] = tenTinhchatXuat.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchatKhac.ToString();
            rTinhchat[Tentinhchat] = tenTinhchatKhac.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchat_NhapKhoThanhPham.ToString();
            rTinhchat[Tentinhchat] = tenTinhchat_NhapKhoThanhpham.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchat_NhapNVLThua.ToString();
            rTinhchat[Tentinhchat] = tenTinhchat_NhapNVLThua.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchat_XuatKhoNVL.ToString();
            rTinhchat[Tentinhchat] = tenTinhchat_XuatKhoNVL.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = maTinhchat_Lenhxuatkho.ToString();
            rTinhchat[Tentinhchat] = tenTinhchat_Lenhxuatkho.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            rTinhchat = dtTinhchatNhapXuat.NewRow();
            rTinhchat[Tinhchat] = matinhchat_Nhapkhau.ToString();
            rTinhchat[Tentinhchat] = tenTinhchat_Nhapkhau.ToString();
            dtTinhchatNhapXuat.Rows.Add(rTinhchat);

            return dtTinhchatNhapXuat;
        }
        #endregion
        #region Hình Thức thanh toán
        public static string Tienmat = "TM";
        public static string Chuyenkhoan = "CK";
        public static string TMCK = "TM/CK";
        public static string UNC = "UNC";
        public static string SECCK = "SECCK";
        public static string SECTM = "SECTM";
        public static string CTT = "CTT";
        public static DataTable DT_HinhthuThanhtoan()
        {
            DataTable dtHinhthucTT = new DataTable();
            string tenCTT = "Chưa thanh toán";
            string tenTienmat = "Tiền mặt";
            string tenChuyenkhoan = "Chuyển khoản";
            string tenTMCK = "TM/CK";
            string tenUNC = "Ủy nhiệm chi";
            string tenSECCK = "Séc chuyển khoản";
            string tenSECTM = "Séc tiền mặt";

            if (dtHinhthucTT.Columns.Contains(Giatri) == false) dtHinhthucTT.Columns.Add(Giatri, typeof(string));
            if (dtHinhthucTT.Columns.Contains(Ten) == false) dtHinhthucTT.Columns.Add(Ten, typeof(string));
            DataRow rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = Tienmat.ToString();
            rInsert[Ten] = tenTienmat.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = Chuyenkhoan.ToString();
            rInsert[Ten] = tenChuyenkhoan.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = TMCK.ToString();
            rInsert[Ten] = tenTMCK.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = UNC.ToString();
            rInsert[Ten] = tenUNC.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = SECCK.ToString();
            rInsert[Ten] = tenSECCK.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = SECTM.ToString();
            rInsert[Ten] = tenSECTM.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            rInsert = dtHinhthucTT.NewRow();
            rInsert[Giatri] = CTT.ToString();
            rInsert[Ten] = tenCTT.ToString();
            dtHinhthucTT.Rows.Add(rInsert);

            return dtHinhthucTT;
        }
        #endregion
        #region Định nghĩa các cột trong bảng xuất nhập tồn
        public static string DataBaseMain = "MART";
        public static string DataBaseXnt = "dtvxnt";
        public static string Toncuoikysl = "Toncuoikysl";
        public static string Toncuoikygt = "Toncuoikygt";
        public static string Giavon = "Giavon";
        #endregion

        #region Định nghĩa datatable Tài khoản cho PTNX
        public static string maTKGiavonvattu = "1";
        public static string maTKChinh = "2";
        public static string maTKNhapkhau = "3";
        public static string maTKThuedacbiet = "4";
        public static string maTKThueGTGT = "5";
        public static string maTKChieukhau = "6";
        public static string maTKGiamgia = "7";
        public static string maTKBanam = "8";
        public static string maTKLephi = "9";
        public static string maTKChiphi = "10";
        public static string maTKChiphikhac = "11";
        public static string maTKKhuyenmai = "12";
        public static string maTKThuekhautru = "13";
        public static string maTKChietkhausaubanhang = "14";

        public static DataTable dtTaiKhoanPTNX()
        {
            DataTable dtTaiKhoanPTNX = new DataTable();
            dtTaiKhoanPTNX.Columns.Add("Matk", typeof(string));
            dtTaiKhoanPTNX.Columns.Add("Tentk", typeof(string));
            dtTaiKhoanPTNX.Columns.Add("TKno", typeof(string));
            dtTaiKhoanPTNX.Columns.Add("TKnomacdinh", typeof(string));
            dtTaiKhoanPTNX.Columns.Add("TKco", typeof(string));
            dtTaiKhoanPTNX.Columns.Add("TKcomacdinh", typeof(string));

            DataRow rowTKGVVT = dtTaiKhoanPTNX.NewRow();
            rowTKGVVT["Matk"] = maTKGiavonvattu;
            rowTKGVVT["Tentk"] = "Tài khoản giá vôn/vật tư";
            rowTKGVVT["Tkno"] = rowTKGVVT["TKnomacdinh"] = rowTKGVVT["TKco"] = rowTKGVVT["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKGVVT);

            DataRow rowTKC = dtTaiKhoanPTNX.NewRow();
            rowTKC["Matk"] = maTKChinh;
            rowTKC["Tentk"] = "Tài khoản chính";
            rowTKC["Tkno"] = rowTKC["TKnomacdinh"] = rowTKC["TKco"] = rowTKC["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKC);

            DataRow rowTKNK = dtTaiKhoanPTNX.NewRow();
            rowTKNK["Matk"] = maTKNhapkhau;
            rowTKNK["Tentk"] = "Tài khoản nhập khẩu";
            rowTKNK["Tkno"] = rowTKNK["TKnomacdinh"] = rowTKNK["TKco"] = rowTKNK["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKNK);

            DataRow rowTKTDB = dtTaiKhoanPTNX.NewRow();
            rowTKTDB["Matk"] = maTKThuedacbiet;
            rowTKTDB["Tentk"] = "Tài khoản thuế đặt biệt";
            rowTKNK["Tkno"] = rowTKTDB["TKnomacdinh"] = rowTKTDB["TKco"] = rowTKTDB["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKTDB);

            DataRow rowTKTGTGT = dtTaiKhoanPTNX.NewRow();
            rowTKTGTGT["Matk"] = maTKThueGTGT;
            rowTKTGTGT["Tentk"] = "Tài khoản thuế GTGT";
            rowTKTGTGT["Tkno"] = rowTKTGTGT["TKnomacdinh"] = rowTKTGTGT["TKco"] = rowTKTGTGT["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKTGTGT);

            DataRow rowCK = dtTaiKhoanPTNX.NewRow();
            rowCK["Matk"] = maTKChieukhau;
            rowCK["Tentk"] = "Tài khoản chiết khâu";
            rowCK["Tkno"] = rowCK["TKnomacdinh"] = rowCK["TKco"] = rowCK["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowCK);

            DataRow rowTKGG = dtTaiKhoanPTNX.NewRow();
            rowTKGG["Matk"] = maTKGiamgia;
            rowTKGG["Tentk"] = "Tài khoản giảm giá";
            rowTKGG["Tkno"] = rowTKGG["TKnomacdinh"] = rowTKGG["TKco"] = rowTKGG["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKGG);

            DataRow rowTKBA = dtTaiKhoanPTNX.NewRow();
            rowTKBA["Matk"] = maTKBanam;
            rowTKBA["Tentk"] = "Tài khoản bán âm";
            rowTKBA["Tkno"] = rowTKBA["TKnomacdinh"] = rowTKBA["TKco"] = rowTKBA["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKBA);

            DataRow rowTKLP = dtTaiKhoanPTNX.NewRow();
            rowTKLP["Matk"] = maTKLephi;
            rowTKLP["Tentk"] = "Tài khoản lệ phí";
            rowTKLP["Tkno"] = rowTKLP["TKnomacdinh"] = rowTKLP["TKco"] = rowTKLP["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKLP);

            DataRow rowTKCP = dtTaiKhoanPTNX.NewRow();
            rowTKCP["Matk"] = maTKChiphi;
            rowTKCP["Tentk"] = "Tài khoản chi phí";
            rowTKCP["Tkno"] = rowTKCP["TKnomacdinh"] = rowTKCP["TKco"] = rowTKCP["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKCP);

            DataRow rowTKCPK = dtTaiKhoanPTNX.NewRow();
            rowTKCPK["Matk"] = maTKChiphikhac;
            rowTKCPK["Tentk"] = "Tài khoản chi phí khác";
            rowTKCPK["Tkno"] = rowTKCPK["TKnomacdinh"] = rowTKCPK["TKco"] = rowTKCPK["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKCPK);

            DataRow rowTKKM = dtTaiKhoanPTNX.NewRow();
            rowTKKM["Matk"] = maTKKhuyenmai;
            rowTKKM["Tentk"] = "Tài khoản khuyến mại";
            rowTKKM["Tkno"] = rowTKKM["TKnomacdinh"] = rowTKKM["TKco"] = rowTKKM["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKKM);

            DataRow rowTKTKC = dtTaiKhoanPTNX.NewRow();
            rowTKTKC["Matk"] = maTKThuekhautru;
            rowTKTKC["Tentk"] = "Tài khoản thuế khấu trừ";
            rowTKTKC["Tkno"] = rowTKTKC["TKnomacdinh"] = rowTKTKC["TKco"] = rowTKTKC["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKTKC);

            DataRow rowTKCKSBH = dtTaiKhoanPTNX.NewRow();
            rowTKCKSBH["Matk"] = maTKChietkhausaubanhang;
            rowTKCKSBH["Tentk"] = "Tài khoản CK sau bán hàng";
            rowTKCKSBH["Tkno"] = rowTKCKSBH["TKnomacdinh"] = rowTKCKSBH["TKco"] = rowTKCKSBH["TKcomacdinh"] = "";
            dtTaiKhoanPTNX.Rows.Add(rowTKCKSBH);

            return dtTaiKhoanPTNX;
        }
        #endregion
        #region Định nghĩa mã các đối tượng theo dõi của tài khoản
        public static string doituongNCC = "NHACUNGCAP";
        public static string doituongKH = "KHACHHANG";
        public static string doituongNHANVIEN = "NHANVIEN";
        public static string doituongKMCP = "KMCP";
        public static string doituongHOPDONG = "HOPDONG";
        #endregion

        #region Định nghĩa chương trình khuyến mại
        public static int kmTheomathang = 1;
        public static int kmTheobohang = 2;
        public static int kmTheonganhhang = 3;
        public static int kmTheonhomhang = 4;
        public static int kmTheoNCC = 5;
        public static int kmTrentoandon = 6;
        public static int kmmotsosanpham = 7;
        //tên các cột thêm
        public static string Tendayduban = "Tendayduban";
        public static string TendayduKM = "TendayduKM";
        public static string Tenbo = "Tenbo";
        public static string Tennganh = "Tennganh";
        public static string Tennhomhang = "Tennhomhang";
        public static string Tenkhachhang = "Tenkhachhang";
        //loại áp dụng
        public static int hangtanghang = 1;
        public static int hangchietkhau = 2;
        public static int botanghang = 3;
        public static int nganhchietkhau = 4;
        public static int Kmmotsosanphamck = 5;
        public static int nhomchietkhau = 6;
        public static int NCCchietkhau = 8;
        public static int Chietkhautoandon = 10;
        public static int Kmvinamilk = 11;
        public static int KMnpp = 12;
        //Áp dụng chương trình mua các mặt hàng thuộc 1 nhóm hàng nếu đạt mức tổng tiền cài đặt sẽ được ck % cho tất cả các mặt hàng thuộc nhóm đó
        public static int NhomChietkhauMaxMin = 12;
        public static int kmKhachhangTichDiem = 13;
        public static int KMNhomtanghang = 14;

        public static string Maloaiapdung = "Maloaiapdung";
        public static string Tenloaiapdung = "Tenloaiapdung";
        private static DataTable dtLoaiapdungKM;
        public static DataTable DT_LoaiapdungKM()
        {
            dtLoaiapdungKM = new DataTable();

            if (dtLoaiapdungKM.Columns.Contains(Maloaiapdung) == false) dtLoaiapdungKM.Columns.Add(Maloaiapdung, typeof(int));
            if (dtLoaiapdungKM.Columns.Contains(Tenloaiapdung) == false) dtLoaiapdungKM.Columns.Add(Tenloaiapdung, typeof(string));
            DataRow r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = hangtanghang;
            r[Tenloaiapdung] = "Khuyến mại hàng hàng bán theo số lượng thùng";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = hangchietkhau;
            r[Tenloaiapdung] = "Khuyến mại hàng chiết khấu(giảm giá)";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = Kmmotsosanphamck;
            r[Tenloaiapdung] = "Chiết khấu khi mua 1 số sản phẩm đủ số tiền";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = botanghang;
            r[Tenloaiapdung] = "Khuyến mại bó hàng tặng hàng";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = nganhchietkhau;
            r[Tenloaiapdung] = "Khuyến mại chiết khấu theo ngành hàng";
            dtLoaiapdungKM.Rows.Add(r);

            //r = dtLoaiapdungKM.NewRow();
            //r[Maloaiapdung] = nganhtanghang;
            //r[Tenloaiapdung] = "Khuyến mại tặng hàng theo ngành hàng";
            //dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = nhomchietkhau;
            r[Tenloaiapdung] = "Khuyến mại chiết khấu theo nhóm hàng";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = NCCchietkhau;
            r[Tenloaiapdung] = "Khuyến mại chiết khấu theo nhà cung cấp";
            dtLoaiapdungKM.Rows.Add(r);

            //r = dtLoaiapdungKM.NewRow();
            //r[Maloaiapdung] = NCCtanghang;
            //r[Tenloaiapdung] = "Khuyến mại tặng hàng theo nhà cung cấp";
            //dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = Chietkhautoandon;
            r[Tenloaiapdung] = "Khuyến mại chiết khấu toàn đơn hàng";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = Kmvinamilk;
            r[Tenloaiapdung] = "Khuyến mại vinamilk";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = NhomChietkhauMaxMin;
            r[Tenloaiapdung] = "Chiết khấu theo định mức tổng tiền của nhóm hàng";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = kmKhachhangTichDiem;
            r[Tenloaiapdung] = "Chiết khấu đơn khi khách hàng tích điểm đạt mức";
            dtLoaiapdungKM.Rows.Add(r);

            r = dtLoaiapdungKM.NewRow();
            r[Maloaiapdung] = KMNhomtanghang;
            r[Tenloaiapdung] = "Khuyến mại tặng hàng theo nhóm hàng";
            dtLoaiapdungKM.Rows.Add(r);
            return dtLoaiapdungKM;
        }

        private static DataTable dtapdungcho;
        public static DataTable DT_APDUNGCHO()
        {
            dtapdungcho = new DataTable();

            if (dtapdungcho.Columns.Contains(Maloaiapdung) == false) dtapdungcho.Columns.Add(Maloaiapdung, typeof(int));
            if (dtapdungcho.Columns.Contains(Tenloaiapdung) == false) dtapdungcho.Columns.Add(Tenloaiapdung, typeof(string));
            DataRow r = dtapdungcho.NewRow();
            r[Maloaiapdung] = PublicValue.Luutam;
            r[Tenloaiapdung] = "Xuất bán lẻ";
            dtapdungcho.Rows.Add(r);

            r = dtapdungcho.NewRow();
            r[Maloaiapdung] = PublicValue.Luuthuc;
            r[Tenloaiapdung] = "Xuất bán buôn";
            dtapdungcho.Rows.Add(r);

            return dtapdungcho;
        }
        #endregion

        #region Chương trình khuyến mại dành cho các NPP
        //Các cột thêm ko có trong db
        public static string Diengiai = "Diengiai";
        public static string Soluongdaphanbo = "Soluongdaphanbo";
        public static string Giatridaphanbo = "Giatridaphanbo";
        public static string Giatriconlai = "Giatriconlai";
        public static string Soluongconlai = "Soluongconlai";

        //Kiểu đối tượng apdung
        public static int kmdoituongapdunghanghoa = 1;
        public static int kmdoituongapdungnv = 2;
        //Kiểu đối tượng phân bổ
        public static string kmloaiphanbotheonv = "NV";
        public static string kmloaiphanbotheokh = "KH";
        //Loại khuyến mại
        public static int kmtheosanpham = 1;
        public static int kmtongdonhang = 2;
        private static DataTable dtLoaiKMNPP;
        public static DataTable DT_LoaiKMNPP()
        {
            dtLoaiKMNPP = new DataTable();

            if (dtLoaiKMNPP.Columns.Contains(Maloaiapdung) == false) dtLoaiKMNPP.Columns.Add(Maloaiapdung, typeof(int));
            if (dtLoaiKMNPP.Columns.Contains(Tenloaiapdung) == false) dtLoaiKMNPP.Columns.Add(Tenloaiapdung, typeof(string));
            DataRow r = dtLoaiKMNPP.NewRow();
            r[Maloaiapdung] = kmtheosanpham;
            r[Tenloaiapdung] = "Khuyến mại theo sản phẩm";
            dtLoaiKMNPP.Rows.Add(r);

            r = dtLoaiKMNPP.NewRow();
            r[Maloaiapdung] = kmtongdonhang;
            r[Tenloaiapdung] = "Khuyến mại trên tổng đơn hàng";
            dtLoaiKMNPP.Rows.Add(r);

            //r = dtLoaiKMNPP.NewRow();
            //r[Maloaiapdung] = kmtientanghang;
            //r[Tenloaiapdung] = "Mua một số sản phẩm đạt số tiền được tặng sản phẩm";
            //dtLoaiKMNPP.Rows.Add(r);

            //r = dtLoaiKMNPP.NewRow();
            //r[Maloaiapdung] = kmtientangtien;
            //r[Tenloaiapdung] = "Mua một số sản phẩm đạt số tiền được giảm giá bằng % hoặc tiền";
            //dtLoaiKMNPP.Rows.Add(r);

            //r = dtLoaiKMNPP.NewRow();
            //r[Maloaiapdung] = kmTongtientanghang;
            //r[Tenloaiapdung] = "Tổng tiền trên đơn đạt số tiền được tặng sản phẩm";
            //dtLoaiKMNPP.Rows.Add(r);

            //r = dtLoaiKMNPP.NewRow();
            //r[Maloaiapdung] = kmTongtientangtien;
            //r[Tenloaiapdung] = "Tổng tiền trên đơn đạt số tiền được giảm giá bằng % hoặc tiền";
            //dtLoaiKMNPP.Rows.Add(r);
            return dtLoaiKMNPP;
        }

        private static DataTable dtapdungchonpp;
        public static DataTable DT_APDUNGCHONPP()
        {
            dtapdungchonpp = new DataTable();

            if (dtapdungchonpp.Columns.Contains(Maloaiapdung) == false) dtapdungchonpp.Columns.Add(Maloaiapdung, typeof(int));
            if (dtapdungchonpp.Columns.Contains(Tenloaiapdung) == false) dtapdungchonpp.Columns.Add(Tenloaiapdung, typeof(string));
            DataRow r = dtapdungchonpp.NewRow();
            r[Maloaiapdung] = PublicValue.Luutam;
            r[Tenloaiapdung] = "Khuyến mại phân phối thường";
            dtapdungchonpp.Rows.Add(r);

            r = dtapdungchonpp.NewRow();
            r[Maloaiapdung] = PublicValue.Luuthuc;
            r[Tenloaiapdung] = "Khuyến mại thêm của NPP";
            dtapdungchonpp.Rows.Add(r);

            return dtapdungchonpp;
        }

        public static string Maloaiphanbo = "Maloaiphanbo";
        public static string Tenloaiphanbo = "Tenloaiphanbo";
        private static DataTable dtloaiphanbo;
        public static DataTable DT_LOAIPHANBO()
        {
            dtloaiphanbo = new DataTable();

            if (dtloaiphanbo.Columns.Contains(Maloaiphanbo) == false) dtloaiphanbo.Columns.Add(Maloaiphanbo, typeof(string));
            if (dtloaiphanbo.Columns.Contains(Tenloaiphanbo) == false) dtloaiphanbo.Columns.Add(Tenloaiphanbo, typeof(string));
            DataRow r = dtloaiphanbo.NewRow();
            r[Maloaiphanbo] = "NV";
            r[Tenloaiphanbo] = "Phân bổ theo nhân viên đặt hàng";
            dtloaiphanbo.Rows.Add(r);

            r = dtloaiphanbo.NewRow();
            r[Maloaiphanbo] = "KH";
            r[Tenloaiphanbo] = "Phân bổ theo khách hàng";
            dtloaiphanbo.Rows.Add(r);

            return dtloaiphanbo;
        }

        public static string Makieuphanbo = "Makieuphanbo";
        public static string Tenkieuphanbo = "Tenkieuphanbo";
        private static DataTable dtkieuphanbo;
        public static DataTable DT_KIEUPHANBO()
        {
            dtkieuphanbo = new DataTable();

            if (dtkieuphanbo.Columns.Contains(Makieuphanbo) == false) dtkieuphanbo.Columns.Add(Makieuphanbo, typeof(int));
            if (dtkieuphanbo.Columns.Contains(Tenkieuphanbo) == false) dtkieuphanbo.Columns.Add(Tenkieuphanbo, typeof(string));
            DataRow r = dtkieuphanbo.NewRow();
            r[Makieuphanbo] = PublicValue.Luutam;
            r[Tenkieuphanbo] = "Phân bổ số lượng";
            dtkieuphanbo.Rows.Add(r);

            r = dtkieuphanbo.NewRow();
            r[Makieuphanbo] = PublicValue.Luuthuc;
            r[Tenkieuphanbo] = "Phân bổ số tiền";
            dtkieuphanbo.Rows.Add(r);

            return dtkieuphanbo;
        }

        public static string Makieukm = "Makieukm";
        public static string Tenkieukm = "Tenkieukm";

        public enum KIEUKM { VA = 1, HOAC = 10, TUONGDUONG = 5, MAX = 15 }

        private static DataTable dtkieukm;
        public static DataTable DT_KIEUKM()
        {
            dtkieukm = new DataTable();

            if (dtkieukm.Columns.Contains(Makieukm) == false) dtkieukm.Columns.Add(Makieukm, typeof(int));
            if (dtkieukm.Columns.Contains(Tenkieukm) == false) dtkieukm.Columns.Add(Tenkieukm, typeof(string));
            DataRow r = dtkieukm.NewRow();
            r[Makieukm] = KIEUKM.VA;
            r[Tenkieukm] = "Và sản phẩm";
            dtkieukm.Rows.Add(r);

            r = dtkieukm.NewRow();
            r[Makieukm] = KIEUKM.HOAC;
            r[Tenkieukm] = "Hoặc sản phẩm";
            dtkieukm.Rows.Add(r);

            r = dtkieukm.NewRow();
            r[Makieukm] = KIEUKM.TUONGDUONG;
            r[Tenkieukm] = "Giá trị tương đương";
            dtkieukm.Rows.Add(r);

            r = dtkieukm.NewRow();
            r[Makieukm] = KIEUKM.MAX;
            r[Tenkieukm] = "Giá trị lớn nhất";
            dtkieukm.Rows.Add(r);

            return dtkieukm;
        }
        #endregion


        #region Khai báo biến string gốm danh sách các mã phương thức xuất
        public static string NhomPtnxXuanban = "'" + PublicValue.X_BANBUON + "','" + PublicValue.X_BANLE + "','" + PublicValue.X_NOIBO + "'";
        public static string NhomPtnxNhapmua = "'" + PublicValue.N_KHAU + "','" + PublicValue.N_MUA + "'";
        public static string NhomPtnxXuatKhac = "'" + PublicValue.SX_DHSANXUAT + "','" + PublicValue.SX_LENHSANXUAT + "','" + PublicValue.X_BAN_HA + "','" + PublicValue.X_CHUYENKHO + "','" + PublicValue.X_DICHDANH + "','" + X_DICHVU + "','" + PublicValue.X_DIEUCHINH + "','" + PublicValue.X_HUY
            + "','" + PublicValue.X_KHAC + "','" + PublicValue.X_KIEMKE + "','" + PublicValue.X_SANXUAT + "','" + PublicValue.X_SUDUNG + "','" + PublicValue.X_TAICHE
            + "','" + PublicValue.X_TRALAI + "'";
        public static string NhomPtnxNhapKhac = "'" + PublicValue.N_TRALAI + "','" + PublicValue.N_DICHVU + "','" + PublicValue.N_DIEUCHINH + "','" + PublicValue.N_KHAC
            + PublicValue.N_KIEMKE + "','" + PublicValue.N_NLDDANG + "','" + PublicValue.N_NOIBO + "','" + PublicValue.N_THANHPHAM + "'";
        #endregion

        //#region datatable lookupedit giai đoạn(kỳ)
        //public static string Magiaidoan = "Magiaidoan";
        //public static string Tengiaodoan = "Tengiaodoan";

        //public static DataTable dtGiaidoan()
        //{
        //    DataTable dtgiaidoan = new DataTable();
        //    dtgiaidoan.Columns.Add("Magiaidoan", typeof(int));
        //    dtgiaidoan.Columns.Add("Tengiaodoan", typeof(string));

        //    DataRow rowtuychon = dtgiaidoan.NewRow();
        //    rowtuychon[Magiaidoan] = 0;
        //    rowtuychon[Tengiaodoan] = "Tùy chọn";
        //    dtgiaidoan.Rows.Add(rowtuychon);

        //    DataRow rowNamhientai = dtgiaidoan.NewRow();
        //    rowNamhientai[Magiaidoan] = 1;
        //    rowNamhientai[Tengiaodoan] = "Năm hiện tại";
        //    dtgiaidoan.Rows.Add(rowNamhientai);

        //    DataRow rowQuyhientai = dtgiaidoan.NewRow();
        //    rowQuyhientai[Magiaidoan] = 2;
        //    rowQuyhientai[Tengiaodoan] = "Quý hiện tại";
        //    dtgiaidoan.Rows.Add(rowQuyhientai);

        //    DataRow Quy1 = dtgiaidoan.NewRow();
        //    Quy1[Magiaidoan] = 3;
        //    Quy1[Tengiaodoan] = "Quý 1";
        //    dtgiaidoan.Rows.Add(Quy1);

        //    DataRow Quy2 = dtgiaidoan.NewRow();
        //    Quy2[Magiaidoan] = 4;
        //    Quy2[Tengiaodoan] = "Quý 2";
        //    dtgiaidoan.Rows.Add(Quy2);

        //    DataRow Quy3 = dtgiaidoan.NewRow();
        //    Quy3[Magiaidoan] = 5;
        //    Quy3[Tengiaodoan] = "Quý 3";
        //    dtgiaidoan.Rows.Add(Quy3);

        //    DataRow Quy4 = dtgiaidoan.NewRow();
        //    Quy4[Magiaidoan] = 6;
        //    Quy4[Tengiaodoan] = "Quý 4";
        //    dtgiaidoan.Rows.Add(Quy4);

        //    DataRow thanghientai = dtgiaidoan.NewRow();
        //    thanghientai[Magiaidoan] = 19;
        //    thanghientai[Tengiaodoan] = "Tháng hiện tại";
        //    dtgiaidoan.Rows.Add(thanghientai);

        //    DataRow Thang1 = dtgiaidoan.NewRow();
        //    Thang1[Magiaidoan] = 7;
        //    Thang1[Tengiaodoan] = "Tháng 1";
        //    dtgiaidoan.Rows.Add(Thang1);

        //    DataRow Thang2 = dtgiaidoan.NewRow();
        //    Thang2[Magiaidoan] = 8;
        //    Thang2[Tengiaodoan] = "Tháng 2";
        //    dtgiaidoan.Rows.Add(Thang2);

        //    DataRow Thang3 = dtgiaidoan.NewRow();
        //    Thang3[Magiaidoan] = 9;
        //    Thang3[Tengiaodoan] = "Tháng 3";
        //    dtgiaidoan.Rows.Add(Thang3);

        //    DataRow Thang4 = dtgiaidoan.NewRow();
        //    Thang4[Magiaidoan] = 10;
        //    Thang4[Tengiaodoan] = "Tháng 4";
        //    dtgiaidoan.Rows.Add(Thang4);

        //    DataRow Thang5 = dtgiaidoan.NewRow();
        //    Thang5[Magiaidoan] = 11;
        //    Thang5[Tengiaodoan] = "Tháng 5";
        //    dtgiaidoan.Rows.Add(Thang5);

        //    DataRow Thang6 = dtgiaidoan.NewRow();
        //    Thang6[Magiaidoan] = 12;
        //    Thang6[Tengiaodoan] = "Tháng 6";
        //    dtgiaidoan.Rows.Add(Thang6);

        //    DataRow Thang7 = dtgiaidoan.NewRow();
        //    Thang7[Magiaidoan] = 13;
        //    Thang7[Tengiaodoan] = "Tháng 7";
        //    dtgiaidoan.Rows.Add(Thang7);

        //    DataRow Thang8 = dtgiaidoan.NewRow();
        //    Thang8[Magiaidoan] = 14;
        //    Thang8[Tengiaodoan] = "Tháng 8";
        //    dtgiaidoan.Rows.Add(Thang8);

        //    DataRow Thang9 = dtgiaidoan.NewRow();
        //    Thang9[Magiaidoan] = 15;
        //    Thang9[Tengiaodoan] = "Tháng 9";
        //    dtgiaidoan.Rows.Add(Thang9);

        //    DataRow Thang10 = dtgiaidoan.NewRow();
        //    Thang10[Magiaidoan] = 16;
        //    Thang10[Tengiaodoan] = "Tháng 10";
        //    dtgiaidoan.Rows.Add(Thang10);

        //    DataRow Thang11 = dtgiaidoan.NewRow();
        //    Thang11[Magiaidoan] = 17;
        //    Thang11[Tengiaodoan] = "Tháng 11";
        //    dtgiaidoan.Rows.Add(Thang11);

        //    DataRow Thang12 = dtgiaidoan.NewRow();
        //    Thang12[Magiaidoan] = 18;
        //    Thang12[Tengiaodoan] = "Tháng 12";
        //    dtgiaidoan.Rows.Add(Thang12);

        //    return dtgiaidoan;
        //}
        //#endregion


        // Nhân sự

        public static int Khenthuong = 0;
        public static int Kyluat = 1;

        public static int Cosudung = 1;
        public static int Khongsudung = 0;

        public static int Cohuongluong = 1;
        public static int Khonghuongluong = 0;

        public static string TienBaoHiem = "TienBH";
        public static string TienKyLuat = "TienKL";
        public static string TienLuongHD = "LuongHD";
        public static string TienThuong = "TienThuong";
        public static string TienPhuCap = "TienPC";
        public static string TienLamThem = "LuongLT";
        public static string TienThuNhapKhac = "TienTNK";
        public static string TienVanChuyen = "TienVC";
        public static string TienChaiLong = "TienCL";

        public static int Binhthuong = 1;
        public static int Trachnhiem = 2;
        public static int Giamsat = 3;
        public static int All = 0;
        #region Quy định bảng kê đầu ra và đầu vào
        public static int BangkeDauvao = 1;
        public static int BangkeDaura = 2;
        #endregion
        #region Khai báo trạng thái trạng thái sử dụng (đang hoạt động, đã dừng hoạt động)
        private static DataTable dtTrangthaiSuDung;
        public static DataTable DT_TrangthaiSuDung()
        {
            dtTrangthaiSuDung = new DataTable();
            dtTrangthaiSuDung.Columns.Add("Giatri", typeof(int));
            dtTrangthaiSuDung.Columns.Add("Tentrangthai", typeof(string));

            DataRow drTrangThaiSuDung = dtTrangthaiSuDung.NewRow();
            drTrangThaiSuDung["Tentrangthai"] = "Có sử dụng";
            drTrangThaiSuDung["Giatri"] = 1;

            dtTrangthaiSuDung.Rows.Add(drTrangThaiSuDung);
            dtTrangthaiSuDung.AcceptChanges();

            drTrangThaiSuDung = dtTrangthaiSuDung.NewRow();
            drTrangThaiSuDung["Tentrangthai"] = "Không sử dụng";
            drTrangThaiSuDung["Giatri"] = 0;

            dtTrangthaiSuDung.Rows.Add(drTrangThaiSuDung);
            dtTrangthaiSuDung.AcceptChanges();

            return dtTrangthaiSuDung;
        }
        #endregion
        // End nhân sự
        //------------------------------------------------------
        //----vận tải.
        #region Khai báo trạng thái trạng kinh doanh (đang hoạt động, đã dừng hoạt động)
        private static DataTable dtTrangthaiKinhDoanh;
        public static DataTable DT_TrangthaiKinhDoanh()
        {
            dtTrangthaiKinhDoanh = new DataTable();
            dtTrangthaiKinhDoanh.Columns.Add("Giatri", typeof(int));
            dtTrangthaiKinhDoanh.Columns.Add("Tentrangthai", typeof(string));

            DataRow drTrangThaikinhdoanh = dtTrangthaiKinhDoanh.NewRow();
            drTrangThaikinhdoanh["Tentrangthai"] = "Có kinh doanh";
            drTrangThaikinhdoanh["Giatri"] = 1;

            dtTrangthaiKinhDoanh.Rows.Add(drTrangThaikinhdoanh);
            dtTrangthaiKinhDoanh.AcceptChanges();

            drTrangThaikinhdoanh = dtTrangthaiKinhDoanh.NewRow();
            drTrangThaikinhdoanh["Tentrangthai"] = "Không kinh doanh";
            drTrangThaikinhdoanh["Giatri"] = 0;

            dtTrangthaiKinhDoanh.Rows.Add(drTrangThaikinhdoanh);
            dtTrangthaiKinhDoanh.AcceptChanges();

            return dtTrangthaiKinhDoanh;
        }
        #endregion
        //---------------------------------------------------------------------

        public static string Loaitien = "VND";
        #region Khai bao Maxacnhan cho cac chuc nang

        public enum MAXACNHAN { BAOGIA, DATHANG, LENHSX, DUTINHNVL, DENGHIMUANVL, DATHANGNCC, DENGHILINHLIEU, NHAPTHANHPHAM, DUYETBOM, XUATNGUYENLIEU, XUATBANBUON }
        #endregion
        #region Danh mục tính chất hàng hóa
        private static DataTable dtTinhchatHanghoa;
        public static DataTable DT_TinhchatHanghoa()
        {
            dtTinhchatHanghoa = new DataTable();
            dtTinhchatHanghoa.Columns.Add(PublicValue.Giatri, typeof(string));
            dtTinhchatHanghoa.Columns.Add(PublicValue.Ten, typeof(string));

            DataRow Insert = dtTinhchatHanghoa.NewRow();
            Insert[PublicValue.Ten] = "Vật tư hàng hóa";
            Insert[PublicValue.Giatri] = "1";
            dtTinhchatHanghoa.Rows.Add(Insert);

            Insert = dtTinhchatHanghoa.NewRow();
            Insert[PublicValue.Ten] = "Thành phẩm";
            Insert[PublicValue.Giatri] = "10";
            dtTinhchatHanghoa.Rows.Add(Insert);

            Insert = dtTinhchatHanghoa.NewRow();
            Insert[PublicValue.Ten] = "Dịch vụ";
            Insert[PublicValue.Giatri] = "2";
            dtTinhchatHanghoa.Rows.Add(Insert);

            dtTinhchatHanghoa.AcceptChanges();
            return dtTinhchatHanghoa;
        }
        #endregion
        #region Sản xuất - Danh mục lại tiêu chuẩn
        public static int Tieuchuanchatluong = 1;
        public static int Tieuchuankiemhang = 2;
        private static DataTable dtLoaitieuchuan;
        public static DataTable DT_Sx_Loaitieuchuan()
        {
            dtLoaitieuchuan = new DataTable();
            dtLoaitieuchuan.Columns.Add("Giatri", typeof(int));
            dtLoaitieuchuan.Columns.Add("Ten", typeof(string));

            DataRow TieuchuanCL = dtLoaitieuchuan.NewRow();
            TieuchuanCL["Ten"] = "Tiêu chuẩn chất lượng";
            TieuchuanCL["Giatri"] = Tieuchuanchatluong;

            dtLoaitieuchuan.Rows.Add(TieuchuanCL);

            DataRow TieuchuanCTKH = dtLoaitieuchuan.NewRow();
            TieuchuanCTKH["Ten"] = "Tiêu chuẩn chi tiết kiểm hàng";
            TieuchuanCTKH["Giatri"] = Tieuchuankiemhang;

            dtLoaitieuchuan.Rows.Add(TieuchuanCTKH);

            dtLoaitieuchuan.AcceptChanges();
            return dtLoaitieuchuan;
        }
        #endregion
        #region Sản xuất - Danh mục loại đối tượng tập hợp chi phí
        private static DataTable _dtLoaiDoituongTHCP;
        public static DataTable LoaiDoituongTHCP()
        {
            _dtLoaiDoituongTHCP = new DataTable();
            _dtLoaiDoituongTHCP.Columns.Add("Giatri", typeof(int));
            _dtLoaiDoituongTHCP.Columns.Add("Ten", typeof(string));

            DataRow TieuchuanCL = _dtLoaiDoituongTHCP.NewRow();
            TieuchuanCL["Ten"] = "Sản phẩm";
            TieuchuanCL["Giatri"] = 1;

            _dtLoaiDoituongTHCP.Rows.Add(TieuchuanCL);
            _dtLoaiDoituongTHCP.AcceptChanges();
            return _dtLoaiDoituongTHCP;
        }
        #endregion
        #region Sản xuất - Trạng thái phiếu
        private static DataTable dtTrangthaiphieu;
        public static DataTable DT_Sx_Trangthaiphieu()
        {
            dtTrangthaiphieu = new DataTable();
            dtTrangthaiphieu.Columns.Add("Giatri", typeof(int));
            dtTrangthaiphieu.Columns.Add("Ten", typeof(string));

            DataRow Moi = dtTrangthaiphieu.NewRow();
            Moi["Ten"] = "Phiếu mới";
            Moi["Giatri"] = 1;
            dtTrangthaiphieu.Rows.Add(Moi);

            DataRow Choduyet = dtTrangthaiphieu.NewRow();
            Choduyet["Ten"] = "Đang chờ duyệt";
            Choduyet["Giatri"] = 2;
            dtTrangthaiphieu.Rows.Add(Choduyet);

            DataRow Daduyet = dtTrangthaiphieu.NewRow();
            Daduyet["Ten"] = "Đã duyệt";
            Daduyet["Giatri"] = 10;
            dtTrangthaiphieu.Rows.Add(Daduyet);

            DataRow Dangsx = dtTrangthaiphieu.NewRow();
            Dangsx["Ten"] = "Đang sản xuất";
            Dangsx["Giatri"] = 5;
            dtTrangthaiphieu.Rows.Add(Dangsx);

            DataRow Hoanthanh = dtTrangthaiphieu.NewRow();
            Hoanthanh["Ten"] = "Hoàn thành";
            Hoanthanh["Giatri"] = 3;
            dtTrangthaiphieu.Rows.Add(Hoanthanh);

            DataRow Huy = dtTrangthaiphieu.NewRow();
            Huy["Ten"] = "Hủy";
            Huy["Giatri"] = 0;
            dtTrangthaiphieu.Rows.Add(Huy);

            dtTrangthaiphieu.AcceptChanges();
            return dtTrangthaiphieu;
        }
        #endregion

        #region Sản xuất - Trạng thái phiếu
        private static DataTable dtTrangthaiphieuTiemkiem;
        public static DataTable DT_Sx_TrangthaiphieuTimkiem()
        {
            dtTrangthaiphieuTiemkiem = new DataTable();
            dtTrangthaiphieuTiemkiem.Columns.Add("Giatri", typeof(int));
            dtTrangthaiphieuTiemkiem.Columns.Add("Ten", typeof(string));

            DataRow All = dtTrangthaiphieuTiemkiem.NewRow();
            All["Ten"] = "All";
            All["Giatri"] = 15;
            dtTrangthaiphieuTiemkiem.Rows.Add(All);

            DataRow Moi = dtTrangthaiphieuTiemkiem.NewRow();
            Moi["Ten"] = "Phiếu mới";
            Moi["Giatri"] = 1;
            dtTrangthaiphieuTiemkiem.Rows.Add(Moi);

            DataRow Choduyet = dtTrangthaiphieuTiemkiem.NewRow();
            Choduyet["Ten"] = "Đang chờ duyệt";
            Choduyet["Giatri"] = 2;
            dtTrangthaiphieuTiemkiem.Rows.Add(Choduyet);

            DataRow Daduyet = dtTrangthaiphieuTiemkiem.NewRow();
            Daduyet["Ten"] = "Đã duyệt";
            Daduyet["Giatri"] = 10;
            dtTrangthaiphieuTiemkiem.Rows.Add(Daduyet);

            DataRow Dangsx = dtTrangthaiphieuTiemkiem.NewRow();
            Dangsx["Ten"] = "Đang sản xuất";
            Dangsx["Giatri"] = 5;
            dtTrangthaiphieuTiemkiem.Rows.Add(Dangsx);

            DataRow Hoanthanh = dtTrangthaiphieuTiemkiem.NewRow();
            Hoanthanh["Ten"] = "Hoàn thành";
            Hoanthanh["Giatri"] = 3;
            dtTrangthaiphieuTiemkiem.Rows.Add(Hoanthanh);

            DataRow Huy = dtTrangthaiphieuTiemkiem.NewRow();
            Huy["Ten"] = "Hủy";
            Huy["Giatri"] = 0;
            dtTrangthaiphieuTiemkiem.Rows.Add(Huy);

            dtTrangthaiphieuTiemkiem.AcceptChanges();
            return dtTrangthaiphieuTiemkiem;
        }
        #endregion

        #region Sản xuất - Ca sản xuất
        private static DataTable dtCasanxuat;
        public static DataTable DT_Sx_Casanxuat()
        {
            dtCasanxuat = new DataTable();
            dtCasanxuat.Columns.Add("Giatri", typeof(int));
            dtCasanxuat.Columns.Add("Ten", typeof(string));

            DataRow All = dtCasanxuat.NewRow();
            All["Ten"] = "Ca 1";
            All["Giatri"] = 1;
            dtCasanxuat.Rows.Add(All);

            DataRow Moi = dtCasanxuat.NewRow();
            Moi["Ten"] = "Ca 2";
            Moi["Giatri"] = 2;
            dtCasanxuat.Rows.Add(Moi);

            DataRow Choduyet = dtCasanxuat.NewRow();
            Choduyet["Ten"] = "Ca 3";
            Choduyet["Giatri"] = 3;
            dtCasanxuat.Rows.Add(Choduyet);

            dtCasanxuat.AcceptChanges();
            return dtCasanxuat;
        }
        #endregion

        #region Sản xuất - Trạng thái duyệt phiếu
        private static DataTable dtTrangthaiduyetphieu;
        public static DataTable DT_Sx_Trangthaiduyetphieu()
        {
            dtTrangthaiduyetphieu = new DataTable();
            dtTrangthaiduyetphieu.Columns.Add("Giatri", typeof(int));
            dtTrangthaiduyetphieu.Columns.Add("Ten", typeof(string));

            DataRow Dangcho = dtTrangthaiduyetphieu.NewRow();
            Dangcho["Ten"] = "Đang chờ duyệt (等待批准)";
            Dangcho["Giatri"] = 1;
            dtTrangthaiduyetphieu.Rows.Add(Dangcho);

            DataRow Khongduyet = dtTrangthaiduyetphieu.NewRow();
            Khongduyet["Ten"] = "Không duyệt (不浏览)";
            Khongduyet["Giatri"] = 5;
            dtTrangthaiduyetphieu.Rows.Add(Khongduyet);

            DataRow Daduyet = dtTrangthaiduyetphieu.NewRow();
            Daduyet["Ten"] = "Đã duyệt (已批准)";
            Daduyet["Giatri"] = 10;
            dtTrangthaiduyetphieu.Rows.Add(Daduyet);

            DataRow Huy = dtTrangthaiduyetphieu.NewRow();
            Huy["Ten"] = "Yêu cầu hủy (要求取消)";
            Huy["Giatri"] = 0;
            dtTrangthaiduyetphieu.Rows.Add(Huy);

            dtTrangthaiduyetphieu.AcceptChanges();
            return dtTrangthaiduyetphieu;
        }
        #endregion
        #region Sản xuất - Danh mục tiêu thức phân bổ sản xuất
        private static DataTable dtLoaiphanbo;
        public static DataTable DT_Sx_Loaiphanbo()
        {
            dtLoaiphanbo = new DataTable();
            dtLoaiphanbo.Columns.Add(PublicValue.Giatri, typeof(int));
            dtLoaiphanbo.Columns.Add(PublicValue.Ten, typeof(string));

            DataRow rAdd = dtLoaiphanbo.NewRow();
            rAdd[PublicValue.Ten] = "Phân bổ theo số lượng thành phẩm";
            rAdd[PublicValue.Giatri] = 1;
            dtLoaiphanbo.Rows.Add(rAdd);

            rAdd = dtLoaiphanbo.NewRow();
            rAdd[PublicValue.Ten] = "Phân bổ theo nguyên liệu trực tiếp";
            rAdd[PublicValue.Giatri] = 2;
            dtLoaiphanbo.Rows.Add(rAdd);

            dtLoaiphanbo.AcceptChanges();
            return dtLoaiphanbo;
        }
        #endregion

        #region Phân bổ chi phí mua hàng
        private static DataTable dtLoaiPhanboCpMuahang;
        public static DataTable DT_LoaiPhanboCpMuahang()
        {
            dtLoaiPhanboCpMuahang = new DataTable();
            dtLoaiPhanboCpMuahang.Columns.Add(PublicValue.Giatri, typeof(int));
            dtLoaiPhanboCpMuahang.Columns.Add(PublicValue.Ten, typeof(string));

            DataRow rAdd = dtLoaiPhanboCpMuahang.NewRow();
            rAdd[PublicValue.Ten] = "Tỉ lệ % theo số lượng";
            rAdd[PublicValue.Giatri] = 1;
            dtLoaiPhanboCpMuahang.Rows.Add(rAdd);

            rAdd = dtLoaiPhanboCpMuahang.NewRow();
            rAdd[PublicValue.Ten] = "Tỉ lệ % theo giá trị";
            rAdd[PublicValue.Giatri] = 2;
            dtLoaiPhanboCpMuahang.Rows.Add(rAdd);

            dtLoaiPhanboCpMuahang.AcceptChanges();
            return dtLoaiPhanboCpMuahang;
        }
        #endregion

        #region Tài sản-Trạng thái tài sản
        private static DataTable dtTrangthaitaisan;
        public static DataTable DT_Ts_Trangthaits
        {
            get
            {
                dtTrangthaitaisan = new DataTable();
                dtTrangthaitaisan.Columns.Add("Giatri", typeof(int));
                dtTrangthaitaisan.Columns.Add("Ten", typeof(string));

                DataRow Co = dtTrangthaitaisan.NewRow();
                Co["Ten"] = "Mua mới chưa khấu hao";
                Co["Giatri"] = 1;
                dtTrangthaitaisan.Rows.Add(Co);

                DataRow Tang = dtTrangthaitaisan.NewRow();
                Tang["Ten"] = "Đang khấu hao";
                Tang["Giatri"] = 10;
                dtTrangthaitaisan.Rows.Add(Tang);

                DataRow Ngungkh = dtTrangthaitaisan.NewRow();
                Ngungkh["Ten"] = "Đang dùng, ngừng khấu hao";
                Ngungkh["Giatri"] = 3;
                dtTrangthaitaisan.Rows.Add(Ngungkh);

                DataRow Hetkh = dtTrangthaitaisan.NewRow();
                Hetkh["Ten"] = "Hết khấu hao";
                Hetkh["Giatri"] = 5;
                dtTrangthaitaisan.Rows.Add(Hetkh);

                DataRow khong = dtTrangthaitaisan.NewRow();
                khong["Ten"] = "Đã thanh lý, nhượng bán";
                khong["Giatri"] = 0;
                dtTrangthaitaisan.Rows.Add(khong);

                dtTrangthaitaisan.AcceptChanges();
                return dtTrangthaitaisan;
            }
            set { value = dtTrangthaitaisan; }

        }

        public enum TRANGTHAITAISAN { MOI = 1, DANGKHAUHAO = 10, DANGDUNG = 3, HETKHAUHAO = 5, BANTHANHLY = 0 };
        private static DataTable dtLoaihang;
        public static DataTable DT_Ts_Loaihang
        {
            get
            {
                //public enum LOAIHANG { TSCD = 1, CCDC = 2, CPNH = 3, CPDH = 4 };
                dtLoaihang = new DataTable();
                dtLoaihang.Columns.Add("Giatri", typeof(int));
                dtLoaihang.Columns.Add("Ten", typeof(string));

                DataRow tscd = dtLoaihang.NewRow();
                tscd["Ten"] = "Tài sản cố định";
                tscd["Giatri"] = 1;
                dtLoaihang.Rows.Add(tscd);

                DataRow ccdc = dtLoaihang.NewRow();
                ccdc["Ten"] = "Công cụ dụng cụ";
                ccdc["Giatri"] = 2;
                dtLoaihang.Rows.Add(ccdc);

                DataRow cpnh = dtLoaihang.NewRow();
                cpnh["Ten"] = "Chi phí ngắn hạn";
                cpnh["Giatri"] = 3;
                dtLoaihang.Rows.Add(cpnh);

                DataRow cpdh = dtLoaihang.NewRow();
                cpdh["Ten"] = "Chi phí dài hạn";
                cpdh["Giatri"] = 4;
                dtLoaihang.Rows.Add(cpdh);

                dtLoaihang.AcceptChanges();
                return dtLoaihang;
            }
            set { value = dtLoaihang; }

        }
        #endregion
    }
}