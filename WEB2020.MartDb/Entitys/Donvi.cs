using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Donvi
    {
        public Donvi()
        {
            Baogia = new HashSet<Baogium>();
            Barcodes = new HashSet<Barcode>();
            Bohangcts = new HashSet<Bohangct>();
            Bohangs = new HashSet<Bohang>();
            Dathangs = new HashSet<Dathang>();
            Denghithanhtoans = new HashSet<Denghithanhtoan>();
            Dmchungtus = new HashSet<Dmchungtu>();
            Dmptnxes = new HashSet<Dmptnx>();
            Dmtks = new HashSet<Dmtk>();
            Donvitinhs = new HashSet<Donvitinh>();
            Giaodichquays = new HashSet<Giaodichquay>();
            Khachhangs = new HashSet<Khachhang>();
            Khohangs = new HashSet<Khohang>();
            Khuyenmaicts = new HashSet<Khuyenmaict>();
            Khuyenmais = new HashSet<Khuyenmai>();
            Kiemkes = new HashSet<Kiemke>();
            Kmchiphis = new HashSet<Kmchiphi>();
            Macandientus = new HashSet<Macandientu>();
            Mathangs = new HashSet<Mathang>();
            Menunhomquyens = new HashSet<Menunhomquyen>();
            Nganhhangs = new HashSet<Nganhhang>();
            Nguoidungs = new HashSet<Nguoidung>();
            Nhomhangs = new HashSet<Nhomhang>();
            Nhomkhachhangs = new HashSet<Nhomkhachhang>();
            Nhomkmchiphis = new HashSet<Nhomkmchiphi>();
            Nhomquyenphus = new HashSet<Nhomquyenphu>();
            Nhomquyens = new HashSet<Nhomquyen>();
            NsBangluongs = new HashSet<NsBangluong>();
            NsBaohiems = new HashSet<NsBaohiem>();
            NsBophans = new HashSet<NsBophan>();
            NsCalamviecs = new HashSet<NsCalamviec>();
            NsChucvus = new HashSet<NsChucvu>();
            NsChuyenbophans = new HashSet<NsChuyenbophan>();
            NsCongthuctinhluongs = new HashSet<NsCongthuctinhluong>();
            NsDangkylamthems = new HashSet<NsDangkylamthem>();
            NsDangkynghis = new HashSet<NsDangkynghi>();
            NsDinhmucluongs = new HashSet<NsDinhmucluong>();
            NsKhenthuongkyluats = new HashSet<NsKhenthuongkyluat>();
            NsLichlamviecs = new HashSet<NsLichlamviec>();
            NsLienketnhanviens = new HashSet<NsLienketnhanvien>();
            NsLuongcobans = new HashSet<NsLuongcoban>();
            NsLuonghopdongbophans = new HashSet<NsLuonghopdongbophan>();
            NsLuonghopdongnhanviens = new HashSet<NsLuonghopdongnhanvien>();
            NsLuonghopdongs = new HashSet<NsLuonghopdong>();
            NsNgaynghis = new HashSet<NsNgaynghi>();
            NsPhongbans = new HashSet<NsPhongban>();
            NsPhucapnhanviens = new HashSet<NsPhucapnhanvien>();
            NsPhucaps = new HashSet<NsPhucap>();
            NsQdkhenthuongkyluats = new HashSet<NsQdkhenthuongkyluat>();
            Quayhangs = new HashSet<Quayhang>();
            Quyctkts = new HashSet<Quyctkt>();
            SxDenghilinhlieus = new HashSet<SxDenghilinhlieu>();
            Vuviecs = new HashSet<Vuviec>();
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

        public virtual ICollection<Baogium> Baogia { get; set; }
        public virtual ICollection<Barcode> Barcodes { get; set; }
        public virtual ICollection<Bohangct> Bohangcts { get; set; }
        public virtual ICollection<Bohang> Bohangs { get; set; }
        public virtual ICollection<Dathang> Dathangs { get; set; }
        public virtual ICollection<Denghithanhtoan> Denghithanhtoans { get; set; }
        public virtual ICollection<Dmchungtu> Dmchungtus { get; set; }
        public virtual ICollection<Dmptnx> Dmptnxes { get; set; }
        public virtual ICollection<Dmtk> Dmtks { get; set; }
        public virtual ICollection<Donvitinh> Donvitinhs { get; set; }
        public virtual ICollection<Giaodichquay> Giaodichquays { get; set; }
        public virtual ICollection<Khachhang> Khachhangs { get; set; }
        public virtual ICollection<Khohang> Khohangs { get; set; }
        public virtual ICollection<Khuyenmaict> Khuyenmaicts { get; set; }
        public virtual ICollection<Khuyenmai> Khuyenmais { get; set; }
        public virtual ICollection<Kiemke> Kiemkes { get; set; }
        public virtual ICollection<Kmchiphi> Kmchiphis { get; set; }
        public virtual ICollection<Macandientu> Macandientus { get; set; }
        public virtual ICollection<Mathang> Mathangs { get; set; }
        public virtual ICollection<Menunhomquyen> Menunhomquyens { get; set; }
        public virtual ICollection<Nganhhang> Nganhhangs { get; set; }
        public virtual ICollection<Nguoidung> Nguoidungs { get; set; }
        public virtual ICollection<Nhomhang> Nhomhangs { get; set; }
        public virtual ICollection<Nhomkhachhang> Nhomkhachhangs { get; set; }
        public virtual ICollection<Nhomkmchiphi> Nhomkmchiphis { get; set; }
        public virtual ICollection<Nhomquyenphu> Nhomquyenphus { get; set; }
        public virtual ICollection<Nhomquyen> Nhomquyens { get; set; }
        public virtual ICollection<NsBangluong> NsBangluongs { get; set; }
        public virtual ICollection<NsBaohiem> NsBaohiems { get; set; }
        public virtual ICollection<NsBophan> NsBophans { get; set; }
        public virtual ICollection<NsCalamviec> NsCalamviecs { get; set; }
        public virtual ICollection<NsChucvu> NsChucvus { get; set; }
        public virtual ICollection<NsChuyenbophan> NsChuyenbophans { get; set; }
        public virtual ICollection<NsCongthuctinhluong> NsCongthuctinhluongs { get; set; }
        public virtual ICollection<NsDangkylamthem> NsDangkylamthems { get; set; }
        public virtual ICollection<NsDangkynghi> NsDangkynghis { get; set; }
        public virtual ICollection<NsDinhmucluong> NsDinhmucluongs { get; set; }
        public virtual ICollection<NsKhenthuongkyluat> NsKhenthuongkyluats { get; set; }
        public virtual ICollection<NsLichlamviec> NsLichlamviecs { get; set; }
        public virtual ICollection<NsLienketnhanvien> NsLienketnhanviens { get; set; }
        public virtual ICollection<NsLuongcoban> NsLuongcobans { get; set; }
        public virtual ICollection<NsLuonghopdongbophan> NsLuonghopdongbophans { get; set; }
        public virtual ICollection<NsLuonghopdongnhanvien> NsLuonghopdongnhanviens { get; set; }
        public virtual ICollection<NsLuonghopdong> NsLuonghopdongs { get; set; }
        public virtual ICollection<NsNgaynghi> NsNgaynghis { get; set; }
        public virtual ICollection<NsPhongban> NsPhongbans { get; set; }
        public virtual ICollection<NsPhucapnhanvien> NsPhucapnhanviens { get; set; }
        public virtual ICollection<NsPhucap> NsPhucaps { get; set; }
        public virtual ICollection<NsQdkhenthuongkyluat> NsQdkhenthuongkyluats { get; set; }
        public virtual ICollection<Quayhang> Quayhangs { get; set; }
        public virtual ICollection<Quyctkt> Quyctkts { get; set; }
        public virtual ICollection<SxDenghilinhlieu> SxDenghilinhlieus { get; set; }
        public virtual ICollection<Vuviec> Vuviecs { get; set; }
    }
}
