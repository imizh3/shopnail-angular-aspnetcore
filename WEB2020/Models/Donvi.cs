using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Donvi
    {
        public Donvi()
        {
            Baogia = new HashSet<Baogia>();
            Barcode = new HashSet<Barcode>();
            Bohang = new HashSet<Bohang>();
            Bohangct = new HashSet<Bohangct>();
            Dathang = new HashSet<Dathang>();
            Denghithanhtoan = new HashSet<Denghithanhtoan>();
            Dmchungtu = new HashSet<Dmchungtu>();
            Dmptnx = new HashSet<Dmptnx>();
            Dmtk = new HashSet<Dmtk>();
            Donvitinh = new HashSet<Donvitinh>();
            Giaodichquay = new HashSet<Giaodichquay>();
            Khachhang = new HashSet<Khachhang>();
            Khohang = new HashSet<Khohang>();
            Khuyenmai = new HashSet<Khuyenmai>();
            Khuyenmaict = new HashSet<Khuyenmaict>();
            Kiemke = new HashSet<Kiemke>();
            Kmchiphi = new HashSet<Kmchiphi>();
            Macandientu = new HashSet<Macandientu>();
            Mathang = new HashSet<Mathang>();
            Menunhomquyen = new HashSet<Menunhomquyen>();
            Nganhhang = new HashSet<Nganhhang>();
            Nguoidung = new HashSet<Nguoidung>();
            Nhomhang = new HashSet<Nhomhang>();
            Nhomkhachhang = new HashSet<Nhomkhachhang>();
            Nhomkmchiphi = new HashSet<Nhomkmchiphi>();
            Nhomquyen = new HashSet<Nhomquyen>();
            Nhomquyenphu = new HashSet<Nhomquyenphu>();
            NsBangluong = new HashSet<NsBangluong>();
            NsBaohiem = new HashSet<NsBaohiem>();
            NsBophan = new HashSet<NsBophan>();
            NsCalamviec = new HashSet<NsCalamviec>();
            NsChucvu = new HashSet<NsChucvu>();
            NsChuyenbophan = new HashSet<NsChuyenbophan>();
            NsCongthuctinhluong = new HashSet<NsCongthuctinhluong>();
            NsDangkylamthem = new HashSet<NsDangkylamthem>();
            NsDangkynghi = new HashSet<NsDangkynghi>();
            NsDinhmucluong = new HashSet<NsDinhmucluong>();
            NsKhenthuongkyluat = new HashSet<NsKhenthuongkyluat>();
            NsLichlamviec = new HashSet<NsLichlamviec>();
            NsLienketnhanvien = new HashSet<NsLienketnhanvien>();
            NsLuongcoban = new HashSet<NsLuongcoban>();
            NsLuonghopdong = new HashSet<NsLuonghopdong>();
            NsLuonghopdongbophan = new HashSet<NsLuonghopdongbophan>();
            NsLuonghopdongnhanvien = new HashSet<NsLuonghopdongnhanvien>();
            NsNgaynghi = new HashSet<NsNgaynghi>();
            NsPhongban = new HashSet<NsPhongban>();
            NsPhucap = new HashSet<NsPhucap>();
            NsPhucapnhanvien = new HashSet<NsPhucapnhanvien>();
            NsQdkhenthuongkyluat = new HashSet<NsQdkhenthuongkyluat>();
            Quayhang = new HashSet<Quayhang>();
            Quyctkt = new HashSet<Quyctkt>();
            SxDenghilinhlieu = new HashSet<SxDenghilinhlieu>();
            Vuviec = new HashSet<Vuviec>();
        }

        public string Madonvi { get; set; }
        public string Madonvicha { get; set; }
        public string Tendonvi { get; set; }
        public string Dienthoai { get; set; }
        public string Dienthoai2 { get; set; }
        public string Fax { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string Masothue { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Giamdoc { get; set; }
        public string Ketoantruong { get; set; }
        public string Nguoibanhang { get; set; }
        public string Nguoikybieu { get; set; }
        public string Kyhieuhoadon { get; set; }
        public string Mausohoadon { get; set; }

        public virtual ICollection<Baogia> Baogia { get; set; }
        public virtual ICollection<Barcode> Barcode { get; set; }
        public virtual ICollection<Bohang> Bohang { get; set; }
        public virtual ICollection<Bohangct> Bohangct { get; set; }
        public virtual ICollection<Dathang> Dathang { get; set; }
        public virtual ICollection<Denghithanhtoan> Denghithanhtoan { get; set; }
        public virtual ICollection<Dmchungtu> Dmchungtu { get; set; }
        public virtual ICollection<Dmptnx> Dmptnx { get; set; }
        public virtual ICollection<Dmtk> Dmtk { get; set; }
        public virtual ICollection<Donvitinh> Donvitinh { get; set; }
        public virtual ICollection<Giaodichquay> Giaodichquay { get; set; }
        public virtual ICollection<Khachhang> Khachhang { get; set; }
        public virtual ICollection<Khohang> Khohang { get; set; }
        public virtual ICollection<Khuyenmai> Khuyenmai { get; set; }
        public virtual ICollection<Khuyenmaict> Khuyenmaict { get; set; }
        public virtual ICollection<Kiemke> Kiemke { get; set; }
        public virtual ICollection<Kmchiphi> Kmchiphi { get; set; }
        public virtual ICollection<Macandientu> Macandientu { get; set; }
        public virtual ICollection<Mathang> Mathang { get; set; }
        public virtual ICollection<Menunhomquyen> Menunhomquyen { get; set; }
        public virtual ICollection<Nganhhang> Nganhhang { get; set; }
        public virtual ICollection<Nguoidung> Nguoidung { get; set; }
        public virtual ICollection<Nhomhang> Nhomhang { get; set; }
        public virtual ICollection<Nhomkhachhang> Nhomkhachhang { get; set; }
        public virtual ICollection<Nhomkmchiphi> Nhomkmchiphi { get; set; }
        public virtual ICollection<Nhomquyen> Nhomquyen { get; set; }
        public virtual ICollection<Nhomquyenphu> Nhomquyenphu { get; set; }
        public virtual ICollection<NsBangluong> NsBangluong { get; set; }
        public virtual ICollection<NsBaohiem> NsBaohiem { get; set; }
        public virtual ICollection<NsBophan> NsBophan { get; set; }
        public virtual ICollection<NsCalamviec> NsCalamviec { get; set; }
        public virtual ICollection<NsChucvu> NsChucvu { get; set; }
        public virtual ICollection<NsChuyenbophan> NsChuyenbophan { get; set; }
        public virtual ICollection<NsCongthuctinhluong> NsCongthuctinhluong { get; set; }
        public virtual ICollection<NsDangkylamthem> NsDangkylamthem { get; set; }
        public virtual ICollection<NsDangkynghi> NsDangkynghi { get; set; }
        public virtual ICollection<NsDinhmucluong> NsDinhmucluong { get; set; }
        public virtual ICollection<NsKhenthuongkyluat> NsKhenthuongkyluat { get; set; }
        public virtual ICollection<NsLichlamviec> NsLichlamviec { get; set; }
        public virtual ICollection<NsLienketnhanvien> NsLienketnhanvien { get; set; }
        public virtual ICollection<NsLuongcoban> NsLuongcoban { get; set; }
        public virtual ICollection<NsLuonghopdong> NsLuonghopdong { get; set; }
        public virtual ICollection<NsLuonghopdongbophan> NsLuonghopdongbophan { get; set; }
        public virtual ICollection<NsLuonghopdongnhanvien> NsLuonghopdongnhanvien { get; set; }
        public virtual ICollection<NsNgaynghi> NsNgaynghi { get; set; }
        public virtual ICollection<NsPhongban> NsPhongban { get; set; }
        public virtual ICollection<NsPhucap> NsPhucap { get; set; }
        public virtual ICollection<NsPhucapnhanvien> NsPhucapnhanvien { get; set; }
        public virtual ICollection<NsQdkhenthuongkyluat> NsQdkhenthuongkyluat { get; set; }
        public virtual ICollection<Quayhang> Quayhang { get; set; }
        public virtual ICollection<Quyctkt> Quyctkt { get; set; }
        public virtual ICollection<SxDenghilinhlieu> SxDenghilinhlieu { get; set; }
        public virtual ICollection<Vuviec> Vuviec { get; set; }
    }
}
