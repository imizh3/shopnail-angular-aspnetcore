using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WEB2020.Models
{
    public partial class MARTContext : DbContext
    {
        public MARTContext()
        {
        }

        public MARTContext(DbContextOptions<MARTContext> options)
            : base(options)
        {
        }

        protected virtual string _connect { get; set; }

        public void SetConnect(string str)
        {
            _connect = str;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_connect))
            {
                optionsBuilder.UseSqlServer(_connect);
            }
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=171.244.51.242;Initial Catalog=MART;User ID=sa;Password=Dtv112233");
            }
        }

        public virtual DbSet<Bangkethuegtgt> Bangkethuegtgt { get; set; }
        public virtual DbSet<Bangkethuegtgtct> Bangkethuegtgtct { get; set; }
        public virtual DbSet<Bangketien> Bangketien { get; set; }
        public virtual DbSet<Bangmau> Bangmau { get; set; }
        public virtual DbSet<Banlect> Banlect { get; set; }
        public virtual DbSet<Baogia> Baogia { get; set; }
        public virtual DbSet<Baogiact> Baogiact { get; set; }
        public virtual DbSet<Barcode> Barcode { get; set; }
        public virtual DbSet<Bohang> Bohang { get; set; }
        public virtual DbSet<Bohangct> Bohangct { get; set; }
        public virtual DbSet<Capma> Capma { get; set; }
        public virtual DbSet<Capmatudong> Capmatudong { get; set; }
        public virtual DbSet<Checkgiaodichquay> Checkgiaodichquay { get; set; }
        public virtual DbSet<Checkgiaodichquayct> Checkgiaodichquayct { get; set; }
        public virtual DbSet<CreateKey> CreateKey { get; set; }
        public virtual DbSet<Ctugoc> Ctugoc { get; set; }
        public virtual DbSet<Dathang> Dathang { get; set; }
        public virtual DbSet<Dathangct> Dathangct { get; set; }
        public virtual DbSet<Denghithanhtoan> Denghithanhtoan { get; set; }
        public virtual DbSet<Denghithanhtoanct> Denghithanhtoanct { get; set; }
        public virtual DbSet<Dinhmucdathang> Dinhmucdathang { get; set; }
        public virtual DbSet<Dinhmucdathangnoibo> Dinhmucdathangnoibo { get; set; }
        public virtual DbSet<DmCachdonggoi> DmCachdonggoi { get; set; }
        public virtual DbSet<DmCongtrinh> DmCongtrinh { get; set; }
        public virtual DbSet<DmDinhmucnguyenlieu> DmDinhmucnguyenlieu { get; set; }
        public virtual DbSet<DmHangmuccongtrinh> DmHangmuccongtrinh { get; set; }
        public virtual DbSet<DmKheuoc> DmKheuoc { get; set; }
        public virtual DbSet<DmLoaicongtrinh> DmLoaicongtrinh { get; set; }
        public virtual DbSet<DmMahaiquan> DmMahaiquan { get; set; }
        public virtual DbSet<DmVanchuyen> DmVanchuyen { get; set; }
        public virtual DbSet<Dmchinhanhnganhang> Dmchinhanhnganhang { get; set; }
        public virtual DbSet<Dmchungtu> Dmchungtu { get; set; }
        public virtual DbSet<Dmloaichungtu> Dmloaichungtu { get; set; }
        public virtual DbSet<Dmloaitk> Dmloaitk { get; set; }
        public virtual DbSet<Dmnganhang> Dmnganhang { get; set; }
        public virtual DbSet<Dmnhomptnx> Dmnhomptnx { get; set; }
        public virtual DbSet<Dmptnx> Dmptnx { get; set; }
        public virtual DbSet<Dmtaikhoanketchuyen> Dmtaikhoanketchuyen { get; set; }
        public virtual DbSet<Dmtaikhoanketchuyenct> Dmtaikhoanketchuyenct { get; set; }
        public virtual DbSet<Dmtieuchuan> Dmtieuchuan { get; set; }
        public virtual DbSet<Dmtk> Dmtk { get; set; }
        public virtual DbSet<Dmtknganhang> Dmtknganhang { get; set; }
        public virtual DbSet<Dondat> Dondat { get; set; }
        public virtual DbSet<Dondatct> Dondatct { get; set; }
        public virtual DbSet<Donvi> Donvi { get; set; }
        public virtual DbSet<Donvitinh> Donvitinh { get; set; }
        public virtual DbSet<Dutoan> Dutoan { get; set; }
        public virtual DbSet<Dutoanct> Dutoanct { get; set; }
        public virtual DbSet<Giaodich> Giaodich { get; set; }
        public virtual DbSet<GiaodichLinkQuy> GiaodichLinkQuy { get; set; }
        public virtual DbSet<Giaodichcktrathuong> Giaodichcktrathuong { get; set; }
        public virtual DbSet<Giaodichct> Giaodichct { get; set; }
        public virtual DbSet<Giaodichctkhuyenmai> Giaodichctkhuyenmai { get; set; }
        public virtual DbSet<Giaodichcttaikhoan> Giaodichcttaikhoan { get; set; }
        public virtual DbSet<Giaodichdongop> Giaodichdongop { get; set; }
        public virtual DbSet<Giaodichgiaonhan> Giaodichgiaonhan { get; set; }
        public virtual DbSet<Giaodichgiaonhanct> Giaodichgiaonhanct { get; set; }
        public virtual DbSet<Giaodichhaiquan> Giaodichhaiquan { get; set; }
        public virtual DbSet<Giaodichphanbo> Giaodichphanbo { get; set; }
        public virtual DbSet<Giaodichquay> Giaodichquay { get; set; }
        public virtual DbSet<Giaodichquayamct> Giaodichquayamct { get; set; }
        public virtual DbSet<Giaodichquayct> Giaodichquayct { get; set; }
        public virtual DbSet<Giaodichtondau> Giaodichtondau { get; set; }
        public virtual DbSet<Giaodichtondauct> Giaodichtondauct { get; set; }
        public virtual DbSet<Gopmavattu> Gopmavattu { get; set; }
        public virtual DbSet<GridSetting> GridSetting { get; set; }
        public virtual DbSet<Kehang> Kehang { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Khachhanggia> Khachhanggia { get; set; }
        public virtual DbSet<Khachhangtt> Khachhangtt { get; set; }
        public virtual DbSet<Khohang> Khohang { get; set; }
        public virtual DbSet<Khohanggia> Khohanggia { get; set; }
        public virtual DbSet<Khuyenmai> Khuyenmai { get; set; }
        public virtual DbSet<Khuyenmaict> Khuyenmaict { get; set; }
        public virtual DbSet<Khuyenmaihangban> Khuyenmaihangban { get; set; }
        public virtual DbSet<Khuyenmaihangkm> Khuyenmaihangkm { get; set; }
        public virtual DbSet<Kichthuocsp> Kichthuocsp { get; set; }
        public virtual DbSet<Kiemke> Kiemke { get; set; }
        public virtual DbSet<Kiemkect> Kiemkect { get; set; }
        public virtual DbSet<Kmchiphi> Kmchiphi { get; set; }
        public virtual DbSet<LichDathang> LichDathang { get; set; }
        public virtual DbSet<Lichsugiaodichgopdon> Lichsugiaodichgopdon { get; set; }
        public virtual DbSet<Loaikhachhang> Loaikhachhang { get; set; }
        public virtual DbSet<Loaikhohang> Loaikhohang { get; set; }
        public virtual DbSet<Macandientu> Macandientu { get; set; }
        public virtual DbSet<Mahshaiquan> Mahshaiquan { get; set; }
        public virtual DbSet<MartLog> MartLog { get; set; }
        public virtual DbSet<Mathang> Mathang { get; set; }
        public virtual DbSet<MathangSerial> MathangSerial { get; set; }
        public virtual DbSet<Mathanggiaban> Mathanggiaban { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Menunhomquyen> Menunhomquyen { get; set; }
        public virtual DbSet<Nganhhang> Nganhhang { get; set; }
        public virtual DbSet<Ngayphatsinh> Ngayphatsinh { get; set; }
        public virtual DbSet<Ngoaite> Ngoaite { get; set; }
        public virtual DbSet<Nguoidung> Nguoidung { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Nhanvienkhachhang> Nhanvienkhachhang { get; set; }
        public virtual DbSet<Nhomhang> Nhomhang { get; set; }
        public virtual DbSet<Nhomkhachhang> Nhomkhachhang { get; set; }
        public virtual DbSet<Nhomkmchiphi> Nhomkmchiphi { get; set; }
        public virtual DbSet<Nhomquyen> Nhomquyen { get; set; }
        public virtual DbSet<Nhomquyenphu> Nhomquyenphu { get; set; }
        public virtual DbSet<Nhomvattu> Nhomvattu { get; set; }
        public virtual DbSet<Nhomvuviec> Nhomvuviec { get; set; }
        public virtual DbSet<NsBangchamcong> NsBangchamcong { get; set; }
        public virtual DbSet<NsBangchamcongct> NsBangchamcongct { get; set; }
        public virtual DbSet<NsBangluong> NsBangluong { get; set; }
        public virtual DbSet<NsBangluongct> NsBangluongct { get; set; }
        public virtual DbSet<NsBangluongphat> NsBangluongphat { get; set; }
        public virtual DbSet<NsBangluongphucap> NsBangluongphucap { get; set; }
        public virtual DbSet<NsBangluongthuong> NsBangluongthuong { get; set; }
        public virtual DbSet<NsBaohiem> NsBaohiem { get; set; }
        public virtual DbSet<NsBaohiemnhanvien> NsBaohiemnhanvien { get; set; }
        public virtual DbSet<NsBophan> NsBophan { get; set; }
        public virtual DbSet<NsCalamviec> NsCalamviec { get; set; }
        public virtual DbSet<NsChucvu> NsChucvu { get; set; }
        public virtual DbSet<NsChuyenbophan> NsChuyenbophan { get; set; }
        public virtual DbSet<NsCongthuctinhluong> NsCongthuctinhluong { get; set; }
        public virtual DbSet<NsDangkylamthem> NsDangkylamthem { get; set; }
        public virtual DbSet<NsDangkylamthemct> NsDangkylamthemct { get; set; }
        public virtual DbSet<NsDangkynghi> NsDangkynghi { get; set; }
        public virtual DbSet<NsDangkynghict> NsDangkynghict { get; set; }
        public virtual DbSet<NsDinhmucluong> NsDinhmucluong { get; set; }
        public virtual DbSet<NsGanlichlamviec> NsGanlichlamviec { get; set; }
        public virtual DbSet<NsKhenthuongkyluat> NsKhenthuongkyluat { get; set; }
        public virtual DbSet<NsLichlamviec> NsLichlamviec { get; set; }
        public virtual DbSet<NsLichlamvieccasangchieu> NsLichlamvieccasangchieu { get; set; }
        public virtual DbSet<NsLichlamviecct> NsLichlamviecct { get; set; }
        public virtual DbSet<NsLichlamviecctthang> NsLichlamviecctthang { get; set; }
        public virtual DbSet<NsLichlamviecthang> NsLichlamviecthang { get; set; }
        public virtual DbSet<NsLienketnhanvien> NsLienketnhanvien { get; set; }
        public virtual DbSet<NsLuongcoban> NsLuongcoban { get; set; }
        public virtual DbSet<NsLuonghopdong> NsLuonghopdong { get; set; }
        public virtual DbSet<NsLuonghopdongbophan> NsLuonghopdongbophan { get; set; }
        public virtual DbSet<NsLuonghopdongnhanvien> NsLuonghopdongnhanvien { get; set; }
        public virtual DbSet<NsNgaynghi> NsNgaynghi { get; set; }
        public virtual DbSet<NsPhongban> NsPhongban { get; set; }
        public virtual DbSet<NsPhucap> NsPhucap { get; set; }
        public virtual DbSet<NsPhucapnhanvien> NsPhucapnhanvien { get; set; }
        public virtual DbSet<NsQdkhenthuongkyluat> NsQdkhenthuongkyluat { get; set; }
        public virtual DbSet<NsQdkhenthuongkyluatct> NsQdkhenthuongkyluatct { get; set; }
        public virtual DbSet<Numbers> Numbers { get; set; }
        public virtual DbSet<Phanbokhuyenmai> Phanbokhuyenmai { get; set; }
        public virtual DbSet<Phanbokhuyenmaict> Phanbokhuyenmaict { get; set; }
        public virtual DbSet<Phanquyenhanghoa> Phanquyenhanghoa { get; set; }
        public virtual DbSet<Printsetting> Printsetting { get; set; }
        public virtual DbSet<Quayhang> Quayhang { get; set; }
        public virtual DbSet<Quyctkt> Quyctkt { get; set; }
        public virtual DbSet<Quyctktct> Quyctktct { get; set; }
        public virtual DbSet<Sodudauky> Sodudauky { get; set; }
        public virtual DbSet<SxDenghilinhlieu> SxDenghilinhlieu { get; set; }
        public virtual DbSet<SxDenghilinhlieuct> SxDenghilinhlieuct { get; set; }
        public virtual DbSet<SxDenghilinhlieuctnguyenlieu> SxDenghilinhlieuctnguyenlieu { get; set; }
        public virtual DbSet<SxDmDoituongthcp> SxDmDoituongthcp { get; set; }
        public virtual DbSet<SxDmHieusuat> SxDmHieusuat { get; set; }
        public virtual DbSet<SxDmXacnhan> SxDmXacnhan { get; set; }
        public virtual DbSet<SxDmXacnhanct> SxDmXacnhanct { get; set; }
        public virtual DbSet<SxDmcongthucsx> SxDmcongthucsx { get; set; }
        public virtual DbSet<SxDmcongthucsxct> SxDmcongthucsxct { get; set; }
        public virtual DbSet<SxDutinhNvl> SxDutinhNvl { get; set; }
        public virtual DbSet<SxDutinhNvlct> SxDutinhNvlct { get; set; }
        public virtual DbSet<SxHieuSuatSanPham> SxHieuSuatSanPham { get; set; }
        public virtual DbSet<SxKehoach> SxKehoach { get; set; }
        public virtual DbSet<SxKehoachct> SxKehoachct { get; set; }
        public virtual DbSet<SxKygiathanh> SxKygiathanh { get; set; }
        public virtual DbSet<SxKygiathanhct> SxKygiathanhct { get; set; }
        public virtual DbSet<SxLenhsx> SxLenhsx { get; set; }
        public virtual DbSet<SxLenhsxct> SxLenhsxct { get; set; }
        public virtual DbSet<SxLenhsxctnguyenlieu> SxLenhsxctnguyenlieu { get; set; }
        public virtual DbSet<SxNvXacnhan> SxNvXacnhan { get; set; }
        public virtual DbSet<SxPhanbochiphichung> SxPhanbochiphichung { get; set; }
        public virtual DbSet<SxPhanbochiphichungRef> SxPhanbochiphichungRef { get; set; }
        public virtual DbSet<SxPhanbochiphichungct> SxPhanbochiphichungct { get; set; }
        public virtual DbSet<SxTiendo> SxTiendo { get; set; }
        public virtual DbSet<Thamsohethong> Thamsohethong { get; set; }
        public virtual DbSet<Tinhthuongnhanvienct> Tinhthuongnhanvienct { get; set; }
        public virtual DbSet<Tkdoituong> Tkdoituong { get; set; }
        public virtual DbSet<TsGiaodich> TsGiaodich { get; set; }
        public virtual DbSet<TsGiaodichct> TsGiaodichct { get; set; }
        public virtual DbSet<TsKhauhao> TsKhauhao { get; set; }
        public virtual DbSet<TsKhauhaoct> TsKhauhaoct { get; set; }
        public virtual DbSet<TsLoaitaisan> TsLoaitaisan { get; set; }
        public virtual DbSet<TsNhomtaisan> TsNhomtaisan { get; set; }
        public virtual DbSet<TsTaisan> TsTaisan { get; set; }
        public virtual DbSet<TsTaisanct> TsTaisanct { get; set; }
        public virtual DbSet<Tuyenduong> Tuyenduong { get; set; }
        public virtual DbSet<VSxTonghopNlLenhsx> VSxTonghopNlLenhsx { get; set; }
        public virtual DbSet<VSxTonghopnhapthanhpham> VSxTonghopnhapthanhpham { get; set; }
        public virtual DbSet<VSxTonghopxuatnl> VSxTonghopxuatnl { get; set; }
        public virtual DbSet<VTsKhauhao> VTsKhauhao { get; set; }
        public virtual DbSet<VVtTonghopnhapncc> VVtTonghopnhapncc { get; set; }
        public virtual DbSet<VVtTonghopxuatdondat> VVtTonghopxuatdondat { get; set; }
        public virtual DbSet<VXdDinhmuc> VXdDinhmuc { get; set; }
        public virtual DbSet<VXdTonghopcongviecphatsinh> VXdTonghopcongviecphatsinh { get; set; }
        public virtual DbSet<VXdTonghopnhapvtcongtrinh> VXdTonghopnhapvtcongtrinh { get; set; }
        public virtual DbSet<VXdTonghopnhapvtthicong> VXdTonghopnhapvtthicong { get; set; }
        public virtual DbSet<VXdTonghopvattucongtrinh> VXdTonghopvattucongtrinh { get; set; }
        public virtual DbSet<VXdTonghopvattuphatsinh> VXdTonghopvattuphatsinh { get; set; }
        public virtual DbSet<Vat> Vat { get; set; }
        public virtual DbSet<VtBaoduongxe> VtBaoduongxe { get; set; }
        public virtual DbSet<VtDinhmucthuexe> VtDinhmucthuexe { get; set; }
        public virtual DbSet<VtGiaodichthuexe> VtGiaodichthuexe { get; set; }
        public virtual DbSet<VtGiaodichthuexect> VtGiaodichthuexect { get; set; }
        public virtual DbSet<VtLichdixe> VtLichdixe { get; set; }
        public virtual DbSet<VtLoaibaoduong> VtLoaibaoduong { get; set; }
        public virtual DbSet<VtLoaichukybaoduong> VtLoaichukybaoduong { get; set; }
        public virtual DbSet<VtLoaithechap> VtLoaithechap { get; set; }
        public virtual DbSet<VtThuonghieu> VtThuonghieu { get; set; }
        public virtual DbSet<VtVaynganhang> VtVaynganhang { get; set; }
        public virtual DbSet<VtXe> VtXe { get; set; }
        public virtual DbSet<VtXetaitrohang> VtXetaitrohang { get; set; }
        public virtual DbSet<Vuviec> Vuviec { get; set; }
        public virtual DbSet<Xacnhanhoadon> Xacnhanhoadon { get; set; }
        public virtual DbSet<XntTaisan> XntTaisan { get; set; }
        public virtual DbSet<Yt> Yt { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bangkethuegtgt>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mabangke })
                    .HasName("PK_Bangkethuegtgt_1");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mabangke)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Maky)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bangkethuegtgtct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mabangke, e.Magiaodichpk });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mabangke)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathang).HasMaxLength(250);

                entity.Property(e => e.Ngayhoadon).HasColumnType("datetime");

                entity.Property(e => e.Sohoadon)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenkhachhang)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Thuesuat).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.Tienhang).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.Tienvat).HasColumnType("decimal(18, 7)");
            });

            modelBuilder.Entity<Bangketien>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Loaict)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Sotien).HasColumnType("decimal(28, 8)");
            });

            modelBuilder.Entity<Bangmau>(entity =>
            {
                entity.HasKey(e => new { e.Mamau, e.Madonvi });

                entity.Property(e => e.Mamau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(1000);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenmau).HasMaxLength(500);
            });

            modelBuilder.Entity<Banlect>(entity =>
            {
                entity.HasKey(e => e.Masieuthi);

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Giavon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Laivon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tban)
                    .HasColumnName("TBan")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tienlai).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tvon)
                    .HasColumnName("TVon")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tylelaile).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Baogia>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Dienthoai).HasMaxLength(50);

                entity.Property(e => e.DienthoaiKh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dieukhoanthanhtoan).HasMaxLength(250);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Madonggoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhacungcap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavanchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoilienhe).HasMaxLength(100);

                entity.Property(e => e.NguoilienheKh).HasMaxLength(100);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tiente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Baogia)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Baogia_Donvi");
            });

            modelBuilder.Entity<Baogiact>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Congxuat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiachuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiachuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiant).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mamau).HasMaxLength(50);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaygiaohang).HasColumnType("datetime");

                entity.Property(e => e.Noigiaohang).HasMaxLength(200);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtiennt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendonnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhangnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecktrendon).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Baogiact_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Baogiact_Baogia");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Baogiact_Mathang");
            });

            modelBuilder.Entity<Barcode>(entity =>
            {
                entity.HasKey(e => new { e.Barcode1, e.Madonvi })
                    .HasName("PK_Barcode_1");

                entity.Property(e => e.Barcode1)
                    .HasColumnName("Barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Barcode)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Barcode_Donvi");
            });

            modelBuilder.Entity<Bohang>(entity =>
            {
                entity.HasKey(e => new { e.Mabohang, e.Madonvi });

                entity.Property(e => e.Mabohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenbo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Bohang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohang_Donvi");
            });

            modelBuilder.Entity<Bohangct>(entity =>
            {
                entity.HasKey(e => new { e.Mabohang, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Mabohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Tongtienbanbuon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tongtienbanle).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylechietkhaubuon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylechietkhaule).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Bohangct)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohangct_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Bohangct)
                    .HasForeignKey(d => new { d.Mabohang, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohangct_Bohang");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Bohangct)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohangct_Mathang");
            });

            modelBuilder.Entity<Capma>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsAuto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kieututang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loaima)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Macappk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mastart)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sokytu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<Capmatudong>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Chucnang, e.Loai });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chucnang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Loai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matruoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotutang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<Checkgiaodichquay>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichquay, e.Madonvi });

                entity.Property(e => e.Magiaodichquay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tennguoiban)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Checkgiaodichquayct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dongia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tensieuthi)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<CreateKey>(entity =>
            {
                entity.HasKey(e => e.IdKey);

                entity.Property(e => e.IdKey)
                    .HasColumnName("idKey")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdKhachhang)
                    .HasColumnName("idKhachhang")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhanHe)
                    .HasColumnName("phanHe")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SoMay)
                    .HasColumnName("soMay")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai)
                    .HasColumnName("trangThai")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ctugoc>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makmchiphi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaict)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvcongno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkdoiung)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayghiso).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotienco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sotiencont).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotienno).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sotiennont).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ctugoc_Donvi");
            });

            modelBuilder.Entity<Dathang>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachigiaohang).HasMaxLength(500);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaygiaodukien).HasColumnType("datetime");

                entity.Property(e => e.Ngaygiaothucte).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoinhanhang).HasMaxLength(200);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Dathang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathang_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Dathang)
                    .HasForeignKey(d => new { d.Maptnx, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathang_Dmptnx");
            });

            modelBuilder.Entity<Dathangct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dongia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Giabanbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giathungchuavat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nhaptkgt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Nhaptksl).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluong)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluongmax).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongmin).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongthung).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Toncuoikygt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Toncuoikysl).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tondaukygt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tondaukysl).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Xuattkgt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Xuattksl).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathangct_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathangct_Dathang");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathangct_Mathang");
            });

            modelBuilder.Entity<Denghithanhtoan>(entity =>
            {
                entity.HasKey(e => new { e.Madenghi, e.Madonvi });

                entity.Property(e => e.Madenghi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(1000);

                entity.Property(e => e.Kemtheo).HasMaxLength(200);

                entity.Property(e => e.Kieuct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieuhoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayctkt).HasColumnType("datetime");

                entity.Property(e => e.Ngayhoadon).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoinoptien).HasMaxLength(500);

                entity.Property(e => e.Soctkt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sohoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Denghithanhtoan)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Denghithanhtoan_Donvi");
            });

            modelBuilder.Entity<Denghithanhtoanct>(entity =>
            {
                entity.Property(e => e.Diengiai).HasMaxLength(200);

                entity.Property(e => e.Dongia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Donvitinh).HasMaxLength(20);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madenghi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhangco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makheuoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makmchiphi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviencongno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviencongnoco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviengiaohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongdk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotienck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiendadoitru).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sotiendadoitrunt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiendk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiennt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Taikhoannhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tienvat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tienvatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckthanhtoanngay).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Dinhmucdathang>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tonmax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tonmin).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Dinhmucdathangnoibo>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Makhohang, e.Masieuthi });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tonmax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tonmin).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DmCachdonggoi>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Madonggoi });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonggoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendonggoi)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DmCongtrinh>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Ma });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.Property(e => e.Dutoan).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(400);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaicongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(200);

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.DmCongtrinh)
                    .HasForeignKey(d => new { d.Madonvi, d.Maloaicongtrinh })
                    .HasConstraintName("FK_DmCongtrinh_DmLoaicongtrinh");
            });

            modelBuilder.Entity<DmDinhmucnguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mactpk, e.Masieuthi });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Heso).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhangthaythe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthithaythe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Tiledat).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(28, 8)");
            });

            modelBuilder.Entity<DmHangmuccongtrinh>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Ma });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.Property(e => e.Dutoan).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(400);

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(200);
            });

            modelBuilder.Entity<DmKheuoc>(entity =>
            {
                entity.HasKey(e => new { e.Makheuoc, e.Madonvi });

                entity.Property(e => e.Makheuoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Noidung)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sotien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelai).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<DmLoaicongtrinh>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Ma });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(400);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(200);
            });

            modelBuilder.Entity<DmMahaiquan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mahaiquan })
                    .HasName("PK_DmMahaiquan_1");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahaiquan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Giabuonchuavat).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Madvtinh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahs)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quycach).HasMaxLength(500);

                entity.Property(e => e.Quydoi)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tendaydu)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Tenrutgon)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DmVanchuyen>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mavanchuyen });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavanchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenvanchuyen)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Dmchinhanhnganhang>(entity =>
            {
                entity.HasKey(e => e.Machinhanh);

                entity.Property(e => e.Machinhanh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi).HasMaxLength(250);

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Manganhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenchinhanh).HasMaxLength(250);

                entity.HasOne(d => d.ManganhangNavigation)
                    .WithMany(p => p.Dmchinhanhnganhang)
                    .HasForeignKey(d => d.Manganhang)
                    .HasConstraintName("FK_Dmchinhanhnganhang_Dmnganhang");
            });

            modelBuilder.Entity<Dmchungtu>(entity =>
            {
                entity.HasKey(e => new { e.Mactu, e.Madonvi })
                    .HasName("PK_TDS_Dmchungtu");

                entity.Property(e => e.Mactu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieuct)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Maloaictu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkcodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matknodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenctu).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Dmchungtu)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmchungtu_Donvi");

                entity.HasOne(d => d.MaloaictuNavigation)
                    .WithMany(p => p.Dmchungtu)
                    .HasForeignKey(d => d.Maloaictu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmchungtu_Dmloaichungtu");
            });

            modelBuilder.Entity<Dmloaichungtu>(entity =>
            {
                entity.HasKey(e => e.Maloaictu)
                    .HasName("PK_TDS_Dmloaichungtu");

                entity.Property(e => e.Maloaictu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaictu).HasMaxLength(150);
            });

            modelBuilder.Entity<Dmloaitk>(entity =>
            {
                entity.HasKey(e => e.Maloaitk)
                    .HasName("PK_TDS_Dmloaitk");

                entity.Property(e => e.Maloaitk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaitk).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmnganhang>(entity =>
            {
                entity.HasKey(e => e.Manganhang);

                entity.Property(e => e.Manganhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi).HasMaxLength(250);

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Tennganhang).HasMaxLength(250);

                entity.Property(e => e.Tenviettat).HasMaxLength(50);
            });

            modelBuilder.Entity<Dmnhomptnx>(entity =>
            {
                entity.HasKey(e => e.Manhomptnx)
                    .HasName("PK_TDS_Dmnhomptnx");

                entity.Property(e => e.Manhomptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Tennhomptnx).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmptnx>(entity =>
            {
                entity.HasKey(e => new { e.Maptnx, e.Madonvi });

                entity.Property(e => e.Maptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ctthanhtien)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ctthucdoanhthu)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cttienchietkhau)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Hinhthuctt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieu).HasMaxLength(10);

                entity.Property(e => e.Manhomptnx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkbanamco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkbanamcodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkbanamno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkbanamnodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhaucodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhaunodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhausaubanhangco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhausaubanhangcodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhausaubanhangno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhausaubanhangnodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphico)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphicodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphikhacco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphikhaccodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphikhacno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphikhacnodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphino)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphinodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkcodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiamgiaco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiamgiacodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiamgiano)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiamgianodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiavon).HasMaxLength(20);

                entity.Property(e => e.Matkgiavondf).HasMaxLength(20);

                entity.Property(e => e.Matkkhuyenmaico)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkkhuyenmaicodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkkhuyenmaino)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkkhuyenmainodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matklephico)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matklephicodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matklephino)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matklephinodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matknhapkhauco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matknhapkhaucodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matknhapkhauno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matknhapkhaunodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matknodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedacbietco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedacbietcodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedacbietno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedacbietnodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtcodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtnodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuekhautruco)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuekhautrucodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuekhautruno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuekhautrunodf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkvtu).HasMaxLength(20);

                entity.Property(e => e.Matkvtudf).HasMaxLength(20);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenptnx).HasMaxLength(250);

                entity.Property(e => e.Tinhchat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Dmptnx)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmptnx_Donvi");

                entity.HasOne(d => d.ManhomptnxNavigation)
                    .WithMany(p => p.Dmptnx)
                    .HasForeignKey(d => d.Manhomptnx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmptnx_Dmnhomptnx");
            });

            modelBuilder.Entity<Dmtaikhoanketchuyen>(entity =>
            {
                entity.HasKey(e => new { e.Matkketchuyen, e.Madonvi });

                entity.Property(e => e.Matkketchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dmtaikhoanketchuyenct>(entity =>
            {
                entity.HasKey(e => new { e.Matkketchuyen, e.Madonvi, e.Matkno, e.Matkco });

                entity.Property(e => e.Matkketchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Tinhchat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dmtieuchuan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Matieuchuan });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matieuchuan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tentieuchuan)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Dmtk>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madonvi });

                entity.Property(e => e.Matk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaitk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkcha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tentk).HasMaxLength(200);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Dmtk)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmtk_Donvi");

                entity.HasOne(d => d.MaloaitkNavigation)
                    .WithMany(p => p.Dmtk)
                    .HasForeignKey(d => d.Maloaitk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmtk_Dmloaitk");
            });

            modelBuilder.Entity<Dmtknganhang>(entity =>
            {
                entity.HasKey(e => e.Taikhoan);

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Machinhanh)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Manganhang)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Sothe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenviettat).HasMaxLength(50);
            });

            modelBuilder.Entity<Dondat>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi })
                    .HasName("PK_SxDondat");

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dieukhoanthanhtoan).HasMaxLength(250);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Madonggoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvkinhdoanh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matinhtrang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavanchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaygiaohang).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Nguoinhanhang).HasMaxLength(50);

                entity.Property(e => e.Tiente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tygia)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dondatct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi })
                    .HasName("PK_SxDondatct");

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dongia)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dongiachuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiachuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiant).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Mamau).HasMaxLength(50);

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtien)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Thanhtiennt)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienck)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tiencknt)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tiencktrendon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendonnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienhangnt)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienvat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienvatnt)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyleck)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tylecktrendon).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Donvi>(entity =>
            {
                entity.HasKey(e => e.Madonvi);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dienthoai2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Giamdoc).HasMaxLength(150);

                entity.Property(e => e.Ketoantruong).HasMaxLength(150);

                entity.Property(e => e.Kyhieuhoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvicha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mausohoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoibanhang).HasMaxLength(150);

                entity.Property(e => e.Nguoikybieu).HasMaxLength(150);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendonvi)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Donvitinh>(entity =>
            {
                entity.HasKey(e => new { e.Madvtinh, e.Madonvi });

                entity.Property(e => e.Madvtinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Donvile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Donvilon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Donvitinh)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donvitinh_Donvi");

                entity.HasOne(d => d.Nguoidung)
                    .WithMany(p => p.Donvitinh)
                    .HasForeignKey(d => new { d.Madonvi, d.Tendangnhap })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donvitinh_Nguoidung");
            });

            modelBuilder.Entity<Dutoan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Madutoan });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madutoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(400);

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tencongtrinh).HasMaxLength(200);

                entity.Property(e => e.Tenhangmuc).HasMaxLength(200);

                entity.Property(e => e.Tongdutoan).HasColumnType("decimal(28, 8)");
            });

            modelBuilder.Entity<Dutoanct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cancu).HasMaxLength(100);

                entity.Property(e => e.Cancu1).HasMaxLength(100);

                entity.Property(e => e.Cancu2).HasMaxLength(100);

                entity.Property(e => e.Dongia).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Dongia1).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Dongia2).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(400);

                entity.Property(e => e.Hesodieuchinh).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Hesodieuchinh1).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Hesodieuchinh2).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madutoan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Tendaydu).HasMaxLength(200);

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Thanhtien1).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Thanhtien2).HasColumnType("decimal(28, 8)");

                entity.HasOne(d => d.Mad)
                    .WithMany()
                    .HasForeignKey(d => new { d.Madonvi, d.Madutoan })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dutoanct_Dutoan");
            });

            modelBuilder.Entity<Giaodich>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachigiaohang).HasMaxLength(250);

                entity.Property(e => e.Kemtheo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieuhoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu).HasMaxLength(50);

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviencongno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviendathang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maquay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mausohoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mucdouutien).HasMaxLength(1000);

                entity.Property(e => e.Ngaychungtugoc).HasColumnType("datetime");

                entity.Property(e => e.Ngayhoadon).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaythanhtoan).HasColumnType("datetime");

                entity.Property(e => e.Nguoigiaohang).HasMaxLength(150);

                entity.Property(e => e.Sochungtugoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sohoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tiendathanhtoan).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Giaodich)
                    .HasForeignKey(d => new { d.Maptnx, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodich_Dmptnx");
            });

            modelBuilder.Entity<GiaodichLinkQuy>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Mactktpk });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactktpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotienthanhtoan)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sotienthanhtoannt)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Giaodichcktrathuong>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Mactktpk, e.Manganh });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactktpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Iskhachhang).HasDefaultValueSql("((1))");

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tiencknam)
                    .HasColumnType("decimal(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienckthang)
                    .HasColumnType("decimal(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tilecknam)
                    .HasColumnType("decimal(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tileckthang)
                    .HasColumnType("decimal(18, 7)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Giaodichct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Doanhthu)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Doanhthunt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiachuavat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dongiachuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiacovat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dongiacovatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Giabanbuonchuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanbuonchuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanbuoncovatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giathungchuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giathungchuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giavon)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Giavonnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Mabohang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machuongtrinhkm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhodieuchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mamau).HasMaxLength(50);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathanhpham)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatnk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Thanhtien)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Thanhtiennt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphikhac).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphikhacnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphivc).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphivcnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tiencknt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrathuong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrathuongnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendonnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienhangnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhangtinhthue)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienvat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienvatnk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatnknt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleck)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tylecktrendon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelaibuon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelaile).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichct_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichct_Giaodich");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichct_Mathang");
            });

            modelBuilder.Entity<Giaodichctkhuyenmai>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chuongtrinhkm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluongkm).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienkm).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Giaodichcttaikhoan>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkbanamco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkbanamno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhausaubanhangco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhausaubanhangno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphikhacco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphikhacno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchiphino)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiamgiaco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiamgiano)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiavon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkkhuyenmaico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkkhuyenmaino)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matklephico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matklephino)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matknhapkhauco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matknhapkhauno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedacbietco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedacbietno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuekhautruco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuekhautruno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkvtu)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Giaodichdongop>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichdongop, e.Madonvi });

                entity.Property(e => e.Magiaodichdongop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(1000);

                entity.Property(e => e.Goptheoin)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Malichxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvgiaohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvlaixe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matuyen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaygopdon).HasColumnType("datetime");

                entity.Property(e => e.Nguoigop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tongsl).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tongst).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tongthantien).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Giaodichgiaonhan>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu).IsUnicode(false);

                entity.Property(e => e.Maquay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Giaodichgiaonhanct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dongia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongnhap).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Giaodichgiaonhanct)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichgiaonhanct_Giaodichgiaonhan");
            });

            modelBuilder.Entity<Giaodichhaiquan>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cangmo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Congty).HasMaxLength(100);

                entity.Property(e => e.Ngaydangky).HasColumnType("datetime");

                entity.Property(e => e.Ngayhoadon).HasColumnType("datetime");

                entity.Property(e => e.Ngayhopdong).HasColumnType("datetime");

                entity.Property(e => e.Nguoikiemhoa).HasMaxLength(50);

                entity.Property(e => e.Nguoithamvan).HasMaxLength(50);

                entity.Property(e => e.Nguoitiepnhan).HasMaxLength(50);

                entity.Property(e => e.Nhanh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phanluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sobill)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sochi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Socmnd)
                    .HasColumnName("SOCMND")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Socongtainer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sodienthoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sohoadon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sohopdong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluongcontainer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sotokhai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sovandon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soxe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Thoigian)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Giaodichphanbo>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichpk, e.Magiaodichphanbo });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphanbo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 7)");
            });

            modelBuilder.Entity<Giaodichquay>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvcongno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maquay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sochungtu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tiendoidiem)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienmat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienqrcode)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tienthe)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Giaodichquay)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquay_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Giaodichquay)
                    .HasForeignKey(d => new { d.Maptnx, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquay_Dmptnx");
            });

            modelBuilder.Entity<Giaodichquayamct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Masieuthi, e.Makhohang, e.Mabohang });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mabohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giavon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichxuly).HasMaxLength(500);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhoban).HasMaxLength(20);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiavon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkvtu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongxuly).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienckbohang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienckdonhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienckmathang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknganhhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknhomhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknhomkhach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiendoidiem).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckbohang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckdonhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckmathang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecknganhhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecknhomhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecknhomkhach).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Giaodichquayct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi, e.Mabohang, e.Makhohang });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mabohang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giavon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkchietkhauno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkgiavon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuegtgtno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkvtu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienckbohang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tienckdonhang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tienckmathang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknganhhang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tiencknhomhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknhomkhach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiendoidiem).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckbohang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tyleckdonhang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tyleckmathang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecknganhhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecknhomhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecknhomkhach)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Giaodichquayct)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquayct_Giaodichquay");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Giaodichquayct)
                    .HasForeignKey(d => new { d.Makhohang, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquayct_Khohang");

                entity.HasOne(d => d.Ma1)
                    .WithMany(p => p.Giaodichquayct)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquayct_Mathang");
            });

            modelBuilder.Entity<Giaodichtondau>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Makhohang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manguoitao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Giaodichtondauct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giavon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvon).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Gopmavattu>(entity =>
            {
                entity.Property(e => e.Dongia).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Dongia1).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madutoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthigop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Thanhtien1).HasColumnType("decimal(28, 8)");
            });

            modelBuilder.Entity<GridSetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Columnname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomquyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kehang>(entity =>
            {
                entity.HasKey(e => new { e.Makehang, e.Madonvi });

                entity.Property(e => e.Makehang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenkehang).HasMaxLength(200);
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => new { e.Makhachhang, e.Maloaikhach, e.Madonvi });

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaikhach)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Congnomax).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Diachi).HasMaxLength(500);

                entity.Property(e => e.Diachigiaohang).HasMaxLength(250);

                entity.Property(e => e.Diem).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dienthoai).HasMaxLength(20);

                entity.Property(e => e.Dienthoai2).HasMaxLength(20);

                entity.Property(e => e.Doanhso).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Manhomkhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Motakhachhang).HasMaxLength(1000);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoigiaodich).HasMaxLength(50);

                entity.Property(e => e.Songaythanhtoan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenkhachhang)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Khachhang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khachhang_Donvi");
            });

            modelBuilder.Entity<Khachhanggia>(entity =>
            {
                entity.HasKey(e => e.Keys)
                    .HasName("PK_Khachhanggia_1");

                entity.Property(e => e.Dongiaban).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.Maapdung)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomkhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tyleck)
                    .HasColumnType("decimal(18, 7)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Khachhangtt>(entity =>
            {
                entity.HasKey(e => new { e.Mact, e.Madonvi });

                entity.Property(e => e.Mact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diemmax).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Diemmin).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Doanhsomax).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Doanhsomin).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tenct).HasMaxLength(250);
            });

            modelBuilder.Entity<Khohang>(entity =>
            {
                entity.HasKey(e => new { e.Makhohang, e.Madonvi });

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi).HasMaxLength(250);

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Maloaikho)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaptnxThe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaptnxTienmat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenkhohang)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Khohang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khohang_Donvi");
            });

            modelBuilder.Entity<Khohanggia>(entity =>
            {
                entity.HasKey(e => new { e.Makhohang, e.Maloaigia, e.Maapdung, e.Madonvi })
                    .HasName("PK_Khohanggia_1");

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaigia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maapdung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giabanbuonchuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giamuachuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giamuacovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayapdung).HasColumnType("datetime");

                entity.Property(e => e.Tilelaibuon)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tilelaile)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyleck).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => new { e.Machuongtrinh, e.Madonvi });

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diengiaikm).HasMaxLength(1000);

                entity.Property(e => e.Loaiapdung).HasComment("Phân biệt dùng cho bán lẻ hay bán buôn");

                entity.Property(e => e.Mact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenchuongtrinh).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Khuyenmai)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khuyenmai_Donvi");
            });

            modelBuilder.Entity<Khuyenmaict>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.Property(e => e.Giatrikmmax).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikmmin).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Mabohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohangban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohangkm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganhhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhacungcap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthiban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthikm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluongban).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongkm).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongmaxinbin).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchietkhau).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tilechietkhau).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Khuyenmaict)
                    .HasForeignKey(d => d.Madonvi)
                    .HasConstraintName("FK_Khuyenmaict_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Khuyenmaict)
                    .HasForeignKey(d => new { d.Machuongtrinh, d.Madonvi })
                    .HasConstraintName("FK_Khuyenmaict_Khuyenmai");
            });

            modelBuilder.Entity<Khuyenmaihangban>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doituongapdung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohangban)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Khuyenmaihangkm>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giatrikm).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohangkm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthikm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluongban).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongkm).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleck).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Kichthuocsp>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi })
                    .HasName("PK_Khichthuocsp");

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chieucao).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Chieudai).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Chieurong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Trongluong).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithOne(p => p.Kichthuocsp)
                    .HasForeignKey<Kichthuocsp>(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khichthuocsp_Mathang");
            });

            modelBuilder.Entity<Kiemke>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makehang)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganhhang)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Manguoitao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavtu)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviecthieu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviecthua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Kiemke)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kiemke_Donvi");
            });

            modelBuilder.Entity<Kiemkect>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giavon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makehang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluongchenhlech).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongkiemke).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongnhap).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongtonmay).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongxuat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchenhlech).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienkiemke).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tientonmay).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Kiemkect)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kiemkect_Kiemke");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Kiemkect)
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .HasConstraintName("FK_Kiemkect_Nganhhang");

                entity.HasOne(d => d.Ma1)
                    .WithMany(p => p.Kiemkect)
                    .HasForeignKey(d => new { d.Manhomhang, d.Madonvi })
                    .HasConstraintName("FK_Kiemkect_Nhomhang");

                entity.HasOne(d => d.Ma2)
                    .WithMany(p => p.Kiemkect)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kiemkect_Mathang");
            });

            modelBuilder.Entity<Kmchiphi>(entity =>
            {
                entity.HasKey(e => new { e.Makmchiphi, e.Madonvi })
                    .HasName("PK_TDS_Kmchiphi");

                entity.Property(e => e.Makmchiphi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomkmchiphi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenkmchiphi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Kmchiphi)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kmchiphi_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Kmchiphi)
                    .HasForeignKey(d => new { d.Manhomkmchiphi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kmchiphi_Nhomkmchiphi");
            });

            modelBuilder.Entity<LichDathang>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydat).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lichsugiaodichgopdon>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichdongop, e.Madonvi, e.Soctugoc });

                entity.Property(e => e.Magiaodichdongop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soctugoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lydotralai).HasMaxLength(1000);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvgiaohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaygop).HasColumnType("datetime");

                entity.Property(e => e.Ngaytralai).HasColumnType("datetime");

                entity.Property(e => e.Nguoigop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoilamtralai)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loaikhachhang>(entity =>
            {
                entity.HasKey(e => e.Maloaikhachhang);

                entity.Property(e => e.Maloaikhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieu)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tenloaikhachang)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loaikhohang>(entity =>
            {
                entity.HasKey(e => e.Maloaikho);

                entity.Property(e => e.Maloaikho)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Tenloaikho).HasMaxLength(150);
            });

            modelBuilder.Entity<Macandientu>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi, e.Itemcode })
                    .HasName("PK_Macandt");

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Macandientu)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Macandientu_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Macandientu)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Macandientu_Mathang");
            });

            modelBuilder.Entity<Mahshaiquan>(entity =>
            {
                entity.HasKey(e => new { e.Mahs, e.Madonvi });

                entity.Property(e => e.Mahs)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MartLog>(entity =>
            {
                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Malog)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoitao)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Noidung).IsRequired();

                entity.Property(e => e.Tenform)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tenmay)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Trangthai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mathang>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi });

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode).HasMaxLength(2000);

                entity.Property(e => e.Giabanbuonchuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giamuachuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giamuacovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giathungbuonchuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giathungbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Hieusuat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kieubaohanh).HasMaxLength(50);

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madvtinh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahaiquan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangcuancc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mahs)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makehang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maplv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatmua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatnk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mota).HasMaxLength(500);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Quycach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendaydu).HasMaxLength(300);

                entity.Property(e => e.Tenviettat).HasMaxLength(250);

                entity.Property(e => e.Thoigianbaohanh).HasMaxLength(50);

                entity.Property(e => e.Tyleckban).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckmua).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelaibuon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelaile).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Mathang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Donvi");

                entity.HasOne(d => d.Mad)
                    .WithMany(p => p.Mathang)
                    .HasForeignKey(d => new { d.Madvtinh, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Donvitinh");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Mathang)
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Nganhhang");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Mathang)
                    .HasForeignKey(d => new { d.Manhomhang, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Nhomhang");
            });

            modelBuilder.Entity<MathangSerial>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi, e.Serial, e.Magiaodichpk });

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Serial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(100);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mamau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomptnx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Mathanggiaban>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giabanbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => new { e.Menuid, e.Madonvi });

                entity.Property(e => e.Menuid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Formname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maphanhe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Menucha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname).HasMaxLength(150);

                entity.Property(e => e.Thamso)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menunhomquyen>(entity =>
            {
                entity.HasKey(e => new { e.Manhomquyen, e.Menuid, e.Madonvi });

                entity.Property(e => e.Manhomquyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Menuid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manguoitao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Menunhomquyen)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menunhomquyen_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Menunhomquyen)
                    .HasForeignKey(d => new { d.Manhomquyen, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menunhomquyen_Nhomquyen");
            });

            modelBuilder.Entity<Nganhhang>(entity =>
            {
                entity.HasKey(e => new { e.Manganh, e.Madonvi });

                entity.Property(e => e.Manganh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loai).HasDefaultValueSql("((10))");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nhaphanphoi).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennganh).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nganhhang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nganhhang_Donvi");
            });

            modelBuilder.Entity<Ngayphatsinh>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh1)
                    .HasColumnName("Ngayphatsinh")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ngoaite>(entity =>
            {
                entity.HasKey(e => new { e.Mangoaite, e.Madonvi });

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenngoaite).HasMaxLength(50);

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Tendangnhap });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Hovaten)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Manguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomquyen)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvcongno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sodienthoai).HasMaxLength(50);

                entity.Property(e => e.Trangthaiof)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nguoidung)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nguoidung_Donvi");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Manhanvien, e.Madonvi });

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dienthoai).HasMaxLength(20);

                entity.Property(e => e.Dienthoai2).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Htquanhuyen)
                    .HasColumnName("HTquanhuyen")
                    .HasMaxLength(500);

                entity.Property(e => e.Htsonha)
                    .HasColumnName("HTsonha")
                    .HasMaxLength(500);

                entity.Property(e => e.Htthonxom)
                    .HasColumnName("HTthonxom")
                    .HasMaxLength(500);

                entity.Property(e => e.Httinhtp)
                    .HasColumnName("HTtinhtp")
                    .HasMaxLength(500);

                entity.Property(e => e.Htxaphuong)
                    .HasColumnName("HTxaphuong")
                    .HasMaxLength(500);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machamcong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machucvu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvienquanly)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomkhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue).HasMaxLength(50);

                entity.Property(e => e.Ngaycap).HasColumnType("datetime");

                entity.Property(e => e.Ngaynhanviec).HasColumnType("datetime");

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Noicap).HasMaxLength(50);

                entity.Property(e => e.Tcquanhuyen)
                    .HasColumnName("TCquanhuyen")
                    .HasMaxLength(500);

                entity.Property(e => e.Tcsonha)
                    .HasColumnName("TCsonha")
                    .HasMaxLength(500);

                entity.Property(e => e.Tcthonxom)
                    .HasColumnName("TCthonxom")
                    .HasMaxLength(500);

                entity.Property(e => e.Tctinhtp)
                    .HasColumnName("TCtinhtp")
                    .HasMaxLength(500);

                entity.Property(e => e.Tcxaphuong)
                    .HasColumnName("TCxaphuong")
                    .HasMaxLength(500);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhanvien)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_Nhanvien_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => new { d.Machucvu, d.Madonvi })
                    .HasConstraintName("FK_Nhanvien_NsChucvu");

                entity.HasOne(d => d.Ma1)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_Nhanvien_NsPhongban");
            });

            modelBuilder.Entity<Nhanvienkhachhang>(entity =>
            {
                entity.HasKey(e => new { e.Manhanvien, e.Makhachhang, e.Madonvi });

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nhomhang>(entity =>
            {
                entity.HasKey(e => new { e.Manhomhang, e.Madonvi });

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhomhang).HasMaxLength(150);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nhomhang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomhang_Donvi");

                entity.HasOne(d => d.Nguoidung)
                    .WithMany(p => p.Nhomhang)
                    .HasForeignKey(d => new { d.Madonvi, d.Tendangnhap })
                    .HasConstraintName("FK_Nhomhang_Nguoidung");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Nhomhang)
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .HasConstraintName("FK_Nhomhang_Nganhhang");
            });

            modelBuilder.Entity<Nhomkhachhang>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Manhomkhachhang });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomkhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaikhach)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhomkhachhang)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Tilechietkhau)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nhomkhachhang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomkhachhang_Donvi");
            });

            modelBuilder.Entity<Nhomkmchiphi>(entity =>
            {
                entity.HasKey(e => new { e.Manhomkmchiphi, e.Madonvi });

                entity.Property(e => e.Manhomkmchiphi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhomkmchiphi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nhomkmchiphi)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomkmchiphi_Nhomkmchiphi");
            });

            modelBuilder.Entity<Nhomquyen>(entity =>
            {
                entity.HasKey(e => new { e.Manhomquyen, e.Madonvi });

                entity.Property(e => e.Manhomquyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhomquyen)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nhomquyen)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomquyen_Donvi");
            });

            modelBuilder.Entity<Nhomquyenphu>(entity =>
            {
                entity.HasKey(e => new { e.Manhomquyen, e.Menuid, e.Madonvi, e.Chucnangphu });

                entity.Property(e => e.Manhomquyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Menuid).HasMaxLength(50);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chucnangphu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nhomquyenphu)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomquyenphu_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Nhomquyenphu)
                    .HasForeignKey(d => new { d.Manhomquyen, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomquyenphu_Nhomquyen");
            });

            modelBuilder.Entity<Nhomvattu>(entity =>
            {
                entity.HasKey(e => new { e.Manhom, e.Madonvi });

                entity.Property(e => e.Manhom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomcha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nhomvuviec>(entity =>
            {
                entity.HasKey(e => new { e.Manhomvuviec, e.Madonvi });

                entity.Property(e => e.Manhomvuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhomvuviec)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<NsBangchamcong>(entity =>
            {
                entity.HasKey(e => new { e.Mabangchamcong, e.Madonvi });

                entity.Property(e => e.Mabangchamcong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsBangchamcong)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsBangchamcong_NsBophan");
            });

            modelBuilder.Entity<NsBangchamcongct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mabangchamcong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machamcong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaylamviec).HasColumnType("datetime");

                entity.Property(e => e.SotienLuonglamthem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tongsogiolam).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tongsogiolamthem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tyleluonglamthem).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Mabangchamcong, d.Madonvi })
                    .HasConstraintName("FK_NsBangchamcongct_NsBangchamcong");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsBangchamcongct_Nhanvien");
            });

            modelBuilder.Entity<NsBangluong>(entity =>
            {
                entity.HasKey(e => new { e.Mabangluong, e.Madonvi });

                entity.Property(e => e.Mabangluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenbangluong).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsBangluong)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBangluong_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsBangluong)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsBangluong_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsBangluong)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsBangluong_NsPhongban");
            });

            modelBuilder.Entity<NsBangluongct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Baohiemxahoi).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Luonggiamsat).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Luonghopdong).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Luongngay).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Luongtrachnhiem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Luongvanchuyen).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Mabangluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sogiolamthem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Songaylamthem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Songaylamviec).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Songaynghi).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Sophutlamthem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Thucnhan).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Thunhapkhac).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tienchailong).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tongluonglamthem).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tongluongthuong).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tongphucap).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tongtienphat).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Mabangluong, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongct_NsBangluong");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongct_Nhanvien");
            });

            modelBuilder.Entity<NsBangluongphat>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mabangluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhenthuongkyluat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Mabangluong, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongphat_NsBangluong");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Makhenthuongkyluat, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongphat_NsKhenthuongkyluat");

                entity.HasOne(d => d.Ma1)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongphat_Nhanvien");
            });

            modelBuilder.Entity<NsBangluongphucap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mabangluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphucap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Mabangluong, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongphucap_NsBangluong");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongphucap_Nhanvien");

                entity.HasOne(d => d.Ma1)
                    .WithMany()
                    .HasForeignKey(d => new { d.Maphucap, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongphucap_NsPhucap");
            });

            modelBuilder.Entity<NsBangluongthuong>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mabangluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhenthuongkyluat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Mabangluong, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongthuong_NsBangluong");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Makhenthuongkyluat, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongthuong_NsKhenthuongkyluat");

                entity.HasOne(d => d.Ma1)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsBangluongthuong_Nhanvien");
            });

            modelBuilder.Entity<NsBaohiem>(entity =>
            {
                entity.HasKey(e => new { e.Mabaohiem, e.Madonvi })
                    .HasName("PK_Nsbaohiem");

                entity.Property(e => e.Mabaohiem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenbaohiem).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsBaohiem)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBaohiem_Donvi");
            });

            modelBuilder.Entity<NsBaohiemnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Mabaohiem, e.Manhanvien, e.Madonvi })
                    .HasName("PK_NsBaohiemnhanvien_1");

                entity.Property(e => e.Mabaohiem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Heso).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Maluongcoban)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsBaohiemnhanvien)
                    .HasForeignKey(d => new { d.Mabaohiem, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBaohiemnhanvien_NsBaohiem");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsBaohiemnhanvien)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBaohiemnhanvien_Nhanvien");
            });

            modelBuilder.Entity<NsBophan>(entity =>
            {
                entity.HasKey(e => new { e.Mabophan, e.Madonvi })
                    .HasName("PK_Nsbophan");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sogiolamtrenca).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tenbophan).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsBophan)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBophan_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsBophan)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsBophan_NsPhongban");
            });

            modelBuilder.Entity<NsCalamviec>(entity =>
            {
                entity.HasKey(e => new { e.Macalamviec, e.Madonvi })
                    .HasName("PK_Nscalamviec");

                entity.Property(e => e.Macalamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tencalamviec).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsCalamviec)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsCalamviec_Donvi");
            });

            modelBuilder.Entity<NsChucvu>(entity =>
            {
                entity.HasKey(e => new { e.Machucvu, e.Madonvi })
                    .HasName("PK_Nschucvu");

                entity.Property(e => e.Machucvu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenchucvu).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsChucvu)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsChucvu_Donvi");
            });

            modelBuilder.Entity<NsChuyenbophan>(entity =>
            {
                entity.HasKey(e => new { e.Machuyenbophan, e.Madonvi });

                entity.Property(e => e.Machuyenbophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tenchuyenbophan).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsChuyenbophan)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsChuyenbophan_NsChuyenbophan");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsChuyenbophan)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsChuyenbophan_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsChuyenbophan)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsChuyenbophan_Nhanvien");
            });

            modelBuilder.Entity<NsCongthuctinhluong>(entity =>
            {
                entity.HasKey(e => new { e.Macongthuc, e.Madonvi })
                    .HasName("PK_NsCongthuctinhluong_1");

                entity.HasIndex(e => e.Macongthuc)
                    .HasName("IX_NsCongthuctinhluong");

                entity.Property(e => e.Macongthuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Congthuctinhluong).HasMaxLength(500);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsCongthuctinhluong)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsCongthuctinhluong_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsCongthuctinhluong)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsCongthuctinhluong_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsCongthuctinhluong)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsCongthuctinhluong_NsPhongban");
            });

            modelBuilder.Entity<NsDangkylamthem>(entity =>
            {
                entity.HasKey(e => new { e.Madangkylamthem, e.Madonvi })
                    .HasName("PK_Nsdangkylamthem");

                entity.Property(e => e.Madangkylamthem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangkylamthem).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsDangkylamthem)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsDangkylamthem_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsDangkylamthem)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsDangkylamthem_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsDangkylamthem)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsDangkylamthem_Nhanvien");
            });

            modelBuilder.Entity<NsDangkylamthemct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Heso).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Madangkylamthem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydangky).HasColumnType("datetime");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Mad)
                    .WithMany()
                    .HasForeignKey(d => new { d.Madangkylamthem, d.Madonvi })
                    .HasConstraintName("FK_NsDangkylamthemct_NsDangkylamthem");
            });

            modelBuilder.Entity<NsDangkynghi>(entity =>
            {
                entity.HasKey(e => new { e.Madangkynghi, e.Madonvi })
                    .HasName("PK_Nsdangkynghi");

                entity.Property(e => e.Madangkynghi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangkynghi).HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsDangkynghi)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsDangkynghi_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsDangkynghi)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsDangkynghi_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsDangkynghi)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsDangkynghi_Nhanvien");
            });

            modelBuilder.Entity<NsDangkynghict>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Heso).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Madangkynghi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydangky).HasColumnType("datetime");

                entity.HasOne(d => d.Mad)
                    .WithMany()
                    .HasForeignKey(d => new { d.Madangkynghi, d.Madonvi })
                    .HasConstraintName("FK_NsDangkynghict_NsDangkynghi");
            });

            modelBuilder.Entity<NsDinhmucluong>(entity =>
            {
                entity.HasKey(e => new { e.Madinhmucluong, e.Madonvi });

                entity.Property(e => e.Madinhmucluong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dinhmucluong).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsDinhmucluong)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsDinhmucluong_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsDinhmucluong)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsDinhmucluong_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsDinhmucluong)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsDinhmucluong_NsPhongban");
            });

            modelBuilder.Entity<NsGanlichlamviec>(entity =>
            {
                entity.HasKey(e => new { e.Maganlichlamviec, e.Madonvi })
                    .HasName("PK_Nsganlichlamviec");

                entity.Property(e => e.Maganlichlamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malichlamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsGanlichlamviec)
                    .HasForeignKey(d => new { d.Malichlamviec, d.Madonvi })
                    .HasConstraintName("FK_NsGanlichlamviec_NsLichlamviec");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsGanlichlamviec)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsGanlichlamviec_Nhanvien");
            });

            modelBuilder.Entity<NsKhenthuongkyluat>(entity =>
            {
                entity.HasKey(e => new { e.Makhenthuongkyluat, e.Madonvi });

                entity.Property(e => e.Makhenthuongkyluat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenkhenthuongkyluat).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsKhenthuongkyluat)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsKhenthuongkyluat_Donvi");
            });

            modelBuilder.Entity<NsLichlamviec>(entity =>
            {
                entity.HasKey(e => new { e.Malichlamviec, e.Madonvi })
                    .HasName("PK_Nslichlamviec");

                entity.Property(e => e.Malichlamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenlichlamviec).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsLichlamviec)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLichlamviec_Donvi");
            });

            modelBuilder.Entity<NsLichlamvieccasangchieu>(entity =>
            {
                entity.HasKey(e => new { e.Maphongban, e.Madonvi })
                    .HasName("PK_NsLichlamvieccasangchieu_1");

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithOne(p => p.NsLichlamvieccasangchieu)
                    .HasForeignKey<NsLichlamvieccasangchieu>(d => new { d.Maphongban, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLichlamvieccasangchieu_NsLichlamvieccasangchieu");
            });

            modelBuilder.Entity<NsLichlamviecct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Macalamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malichlamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathutrongtuan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Macalamviec, d.Madonvi })
                    .HasConstraintName("FK_NsLichlamviecct_NsCalamviec");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Malichlamviec, d.Madonvi })
                    .HasConstraintName("FK_NsLichlamviecct_NsLichlamviec");
            });

            modelBuilder.Entity<NsLichlamviecctthang>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Macalamviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malichlamviecthang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathutrongtuan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaylamviec).HasColumnType("datetime");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Macalamviec, d.Madonvi })
                    .HasConstraintName("FK_NsLichlamviecctthang_NsCalamviec");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Malichlamviecthang, d.Madonvi })
                    .HasConstraintName("FK_NsLichlamviecctthang_NsLichlamviecthang");
            });

            modelBuilder.Entity<NsLichlamviecthang>(entity =>
            {
                entity.HasKey(e => new { e.Malichlamviecthang, e.Madonvi })
                    .HasName("PK_NsLichlamviecthang_1");

                entity.Property(e => e.Malichlamviecthang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenlichlamviecthang).HasMaxLength(250);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsLichlamviecthang)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLichlamviecthang_Nhanvien");
            });

            modelBuilder.Entity<NsLienketnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Mabophanlamthem, e.Madonvi });

                entity.Property(e => e.Mabophanlamthem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hesoluong).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Manhanvienchinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvienphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsLienketnhanvien)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLienketnhanvien_Donvi");
            });

            modelBuilder.Entity<NsLuongcoban>(entity =>
            {
                entity.HasKey(e => new { e.Maluongcoban, e.Madonvi })
                    .HasName("PK_Nsluongcoban");

                entity.Property(e => e.Maluongcoban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenluongcoban).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsLuongcoban)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuongcoban_Donvi");
            });

            modelBuilder.Entity<NsLuonghopdong>(entity =>
            {
                entity.HasKey(e => new { e.Maluonghopdong, e.Madonvi })
                    .HasName("PK_Nsluonghopdong");

                entity.Property(e => e.Maluonghopdong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenluonghopdong).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsLuonghopdong)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdong_Donvi");
            });

            modelBuilder.Entity<NsLuonghopdongbophan>(entity =>
            {
                entity.HasKey(e => new { e.Maluonghopdong, e.Mabophan, e.Madonvi })
                    .HasName("PK_NsLuonghopdongnhanvien");

                entity.Property(e => e.Maluonghopdong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsLuonghopdongbophan)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsLuonghopdongbophan)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsLuonghopdongbophan)
                    .HasForeignKey(d => new { d.Maluonghopdong, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_NsLuonghopdong");
            });

            modelBuilder.Entity<NsLuonghopdongnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Maluonghopdong, e.Manhanvien, e.Madonvi })
                    .HasName("PK_NsLuonghopdongnhanvien_1");

                entity.Property(e => e.Maluonghopdong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsLuonghopdongnhanvien)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_Donvi1");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsLuonghopdongnhanvien)
                    .HasForeignKey(d => new { d.Maluonghopdong, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_NsLuonghopdong1");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsLuonghopdongnhanvien)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_Nhanvien");
            });

            modelBuilder.Entity<NsNgaynghi>(entity =>
            {
                entity.HasKey(e => new { e.Mangaynghi, e.Madonvi })
                    .HasName("PK_Nsngaynghi_1");

                entity.Property(e => e.Mangaynghi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Mabophan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Songaynghi).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsNgaynghi)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsNgaynghi_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsNgaynghi)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsNgaynghi_NsBophan");
            });

            modelBuilder.Entity<NsPhongban>(entity =>
            {
                entity.HasKey(e => new { e.Maphongban, e.Madonvi })
                    .HasName("PK_Nsphongban");

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenphongban).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsPhongban)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhongban_Donvi");
            });

            modelBuilder.Entity<NsPhucap>(entity =>
            {
                entity.HasKey(e => new { e.Maphucap, e.Madonvi })
                    .HasName("PK_Nsphucap");

                entity.Property(e => e.Maphucap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenphucap).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsPhucap)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucap_Donvi");
            });

            modelBuilder.Entity<NsPhucapnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Maphucap, e.Manhanvien, e.Madonvi })
                    .HasName("PK_Nsnhanvienphucap");

                entity.Property(e => e.Maphucap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaybatdau).HasColumnType("datetime");

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsPhucapnhanvien)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucapnhanvien_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsPhucapnhanvien)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucapnhanvien_Nhanvien");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsPhucapnhanvien)
                    .HasForeignKey(d => new { d.Maphucap, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucapnhanvien_NsPhucap");
            });

            modelBuilder.Entity<NsQdkhenthuongkyluat>(entity =>
            {
                entity.HasKey(e => new { e.Maquyetdinh, e.Madonvi });

                entity.Property(e => e.Maquyetdinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.NsQdkhenthuongkyluat)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsQdkhenthuongkyluat_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsQdkhenthuongkyluat)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsQdkhenthuongkyluat_Nhanvien");
            });

            modelBuilder.Entity<NsQdkhenthuongkyluatct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhenthuongkyluat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maquyetdinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Makhenthuongkyluat, d.Madonvi })
                    .HasConstraintName("FK_NsQdkhenthuongkyluatct_NsKhenthuongkyluat");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Maquyetdinh, d.Madonvi })
                    .HasConstraintName("FK_NsQdkhenthuongkyluatct_NsQdkhenthuongkyluat");
            });

            modelBuilder.Entity<Numbers>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.Number).ValueGeneratedNever();
            });

            modelBuilder.Entity<Phanbokhuyenmai>(entity =>
            {
                entity.HasKey(e => new { e.Machuongtrinh, e.Madonvi });

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loaiphanbo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tonggiatriphanbo).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tongsoluongphanbo).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Phanbokhuyenmaict>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doituongapdung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluongduocphanbo).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienduocphanbo).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Phanquyenhanghoa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomquyen)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phanquyenhanghoa_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phanquyenhanghoa_Nganhhang");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhomhang, d.Madonvi })
                    .HasConstraintName("FK_Phanquyenhanghoa_Nhomhang");

                entity.HasOne(d => d.Ma1)
                    .WithMany()
                    .HasForeignKey(d => new { d.Manhomquyen, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phanquyenhanghoa_Nhomquyen");
            });

            modelBuilder.Entity<Printsetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Doituongapdung).HasMaxLength(200);

                entity.Property(e => e.Formname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Item).HasMaxLength(200);

                entity.Property(e => e.Itemname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomquyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quayhang>(entity =>
            {
                entity.HasKey(e => new { e.Maquay, e.Madonvi });

                entity.Property(e => e.Maquay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenquay).HasMaxLength(200);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Quayhang)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quayhang_Donvi");
            });

            modelBuilder.Entity<Quyctkt>(entity =>
            {
                entity.HasKey(e => new { e.Mactktpk, e.Madonvi })
                    .HasName("PK_Quyctkt_1");

                entity.Property(e => e.Mactktpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(1000);

                entity.Property(e => e.Kemtheo).HasMaxLength(200);

                entity.Property(e => e.Kieuct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieuhoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayctkt).HasColumnType("datetime");

                entity.Property(e => e.Ngayhoadon).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoinoptien).HasMaxLength(500);

                entity.Property(e => e.Soctkt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sohoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Quyctkt)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quyctkt_Donvi");
            });

            modelBuilder.Entity<Quyctktct>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactktpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhangco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makheuoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makmchiphi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviencongno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviencongnoco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanviengiaohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sotiendadoitru).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sotiendadoitrunt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiennt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Taikhoannhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tienvat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tienvatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleckthanhtoanngay).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Sodudauky>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Nam, e.Matk, e.Makhachhang, e.Manhanvien, e.Makho, e.Madonvi });

                entity.Property(e => e.Matk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makho)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kieusodu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotienco).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiencont).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotienno).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiennont).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SxDenghilinhlieu>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaylinhlieu).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.SxDenghilinhlieu)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDenghilinhlieu_Donvi");
            });

            modelBuilder.Entity<SxDenghilinhlieuct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madondat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<SxDenghilinhlieuctnguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi, e.Mathanhpham });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathanhpham)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dinhluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Hieusuat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makhachhang).HasMaxLength(20);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<SxDmDoituongthcp>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Madoituongtaphop })
                    .HasName("PK_Doituongtaphopchiphi");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendoituongtaphop)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<SxDmHieusuat>(entity =>
            {
                entity.HasKey(e => new { e.Mahieusuat, e.Madonvi });

                entity.Property(e => e.Mahieusuat)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenhieusuat)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SxDmXacnhan>(entity =>
            {
                entity.HasKey(e => new { e.Maxacnhan, e.Madonvi });

                entity.Property(e => e.Maxacnhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Nghiepvu)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SxDmXacnhanct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maxacnhan, e.Manhanvien });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maxacnhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.SxDmXacnhanct)
                    .HasForeignKey(d => new { d.Maxacnhan, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDmXacnhanct_SxDmXacnhan");
            });

            modelBuilder.Entity<SxDmcongthucsx>(entity =>
            {
                entity.HasKey(e => new { e.Mactpk, e.Madonvi });

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tenct)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SxDmcongthucsxct>(entity =>
            {
                entity.HasKey(e => new { e.Mactpk, e.Masieuthi, e.Madonvi });

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Heso).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhangthaythe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthithaythe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tiledat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.SxDmcongthucsxct)
                    .HasForeignKey(d => new { d.Mactpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDmcongthucsxct_SxDmcongthucsx");
            });

            modelBuilder.Entity<SxDutinhNvl>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.ToTable("SxDutinhNVL");

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dondat)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Kehoach)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Khohang)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Loaigiaodich).HasDefaultValueSql("((1))");

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydukien).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Thanhpham)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SxDutinhNvlct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.ToTable("SxDutinhNVLct");

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongdutinh)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluongnhap)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Toncuoikysl)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.SxDutinhNvlct)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDutinhNVLct_SxDutinhNVL");
            });

            modelBuilder.Entity<SxHieuSuatSanPham>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi })
                    .HasName("PK_SxHieuSuatSanPham_1");

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahieusuat)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SxKehoach>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi })
                    .HasName("PK_SxKehoach_1");

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Magiaodichphu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvkinhdoanh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysanxuat).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SxKehoachct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 7)");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.SxKehoachct)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxKehoachct_SxKehoach");
            });

            modelBuilder.Entity<SxKygiathanh>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Ma });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Ky)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loai).HasDefaultValueSql("((10))");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai).HasDefaultValueSql("((10))");

                entity.Property(e => e.Tungay).HasColumnType("datetime");
            });

            modelBuilder.Entity<SxKygiathanhct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Ma, e.Madoituongtaphop })
                    .HasName("PK_SxDodangcuoikyct");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpdungcusanxuat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpkhac).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Cpkhauhao)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpmuangoai)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnguyenlieugiantiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnguyenlieutructiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnhanconggiantiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnhancongtructiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Giathanh)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongdodang)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tilehoanthanh)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.SxKygiathanhct)
                    .HasForeignKey(d => new { d.Madonvi, d.Ma })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxKygiathanhct_SxKygiathanhct");
            });

            modelBuilder.Entity<SxLenhsx>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Magiaodichphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayketthuc).HasColumnType("datetime");

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaysanxuat).HasColumnType("datetime");

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SxLenhsxct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactsx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madondat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonggoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madtthcp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matieuchuan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matieuchuankiemhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavanchuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongsx).HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<SxLenhsxctnguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dinhluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Hieusuat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Makhachhang).HasMaxLength(20);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<SxNvXacnhan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Manhanvien, e.Manghiepvu });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manghiepvu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Maxacnhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.SxNvXacnhan)
                    .HasForeignKey(d => new { d.Maxacnhan, d.Madonvi })
                    .HasConstraintName("FK_SxNvXacnhan_SxDmXacnhan");
            });

            modelBuilder.Entity<SxPhanbochiphichung>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maky })
                    .HasName("PK_SxPhanbochiphichung_1");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maky)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);
            });

            modelBuilder.Entity<SxPhanbochiphichungRef>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maky, e.Matk, e.Magiaodichpk });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maky)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sotien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sotiendaphanbo).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tilephanbo)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SxPhanbochiphichungct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maky, e.Madoituongtaphop })
                    .HasName("PK_Sxphanbochiphichungct");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maky)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtaphop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpdungcusanxuat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpkhac).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Cpkhauhao)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpmuangoai)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnguyenlieugiantiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnguyenlieutructiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnhanconggiantiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpnhancongtructiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Matk621)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk622)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk6271)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk6272)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk6273)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk6274)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk6277)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk6278)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TilepbCpdungcusanxuat)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpkhac)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpkhauhao)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpmuangoai)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpnhanconggiantiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpnhancongtructiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpnlgiantiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TilepbCpnltructiep)
                    .HasColumnType("decimal(20, 8)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.SxPhanbochiphichungct)
                    .HasForeignKey(d => new { d.Madonvi, d.Maky })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxPhanbochiphichungct_SxPhanbochiphichung");
            });

            modelBuilder.Entity<SxTiendo>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Ngayphatsinh, e.Masieuthi, e.Maca });

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Masieuthi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maca)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Ngaysua).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguyenlieudung).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Nguyenlieuhong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Soluongdutinh).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Soluonghong).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Thamsohethong>(entity =>
            {
                entity.HasKey(e => new { e.Mathamso, e.Madonvi });

                entity.Property(e => e.Mathamso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diengiai).HasMaxLength(500);

                entity.Property(e => e.Giatri)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenthamso).HasMaxLength(250);
            });

            modelBuilder.Entity<Tinhthuongnhanvienct>(entity =>
            {
                entity.HasKey(e => new { e.Matinhthuong, e.Madonvi, e.Manhanvien, e.Maapdung });

                entity.Property(e => e.Matinhthuong)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maapdung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doanhso).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienthuong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tilethuong).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Tkdoituong>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Matk, e.Madoituongtheodoi });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madoituongtheodoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsGiaodich>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichpk });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Kyhieuhoadongd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhacungcap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayhoachtoan).HasColumnType("date");

                entity.Property(e => e.Ngayhoadon).HasColumnType("date");

                entity.Property(e => e.Ngaysua).HasColumnType("date");

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sohoadon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsGiaodichct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichpk, e.Mataisan });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ctdoituong).HasMaxLength(4000);

                entity.Property(e => e.Ctdoituongco).HasMaxLength(200);

                entity.Property(e => e.Ctdoituongno).HasMaxLength(200);

                entity.Property(e => e.Dongia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Madvtinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhonhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhoxuat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaitaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomtaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedbco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuedbno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuenkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuenkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuevatco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkthuevatno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Nguyengia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Quycach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sohieutaisan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tentaisan).HasMaxLength(200);

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatdb).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Vatdb)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.TsGiaodichct)
                    .HasForeignKey(d => new { d.Madonvi, d.Magiaodichpk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsGiaodichct_TsGiaodich");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.TsGiaodichct)
                    .HasForeignKey(d => new { d.Madonvi, d.Mataisan })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsGiaodichct_TsTaisan");
            });

            modelBuilder.Entity<TsKhauhao>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichpk });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("date");

                entity.Property(e => e.Diengiai).HasMaxLength(500);

                entity.Property(e => e.Manhomptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvlapbieu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayhoachtoan).HasColumnType("date");

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("date");
            });

            modelBuilder.Entity<TsKhauhaoct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichpk, e.Mataisan });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ctdoituong)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Giatriconlai).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatriconlaidk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikh).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikhnam).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikhthang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Haomonluyke).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Haomonluykedk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Songaytinhkh).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sothangconlaikhauhao).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sothangdakhauhao).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tentaisan).HasMaxLength(200);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.TsKhauhaoct)
                    .HasForeignKey(d => new { d.Madonvi, d.Magiaodichpk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsKhauhaoct_TsKhauhao");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.TsKhauhaoct)
                    .HasForeignKey(d => new { d.Madonvi, d.Mataisan })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsKhauhaoct_TsTaisan");
            });

            modelBuilder.Entity<TsLoaitaisan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maloaitaisan })
                    .HasName("PK_TsLoaitaisan_1");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaitaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaitaisan).HasMaxLength(200);
            });

            modelBuilder.Entity<TsNhomtaisan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Manhomtaisan })
                    .HasName("PK_TsNhomtaisan_1");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomtaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaitaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tennhomtaisan).HasMaxLength(200);
            });

            modelBuilder.Entity<TsTaisan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mataisan });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dieukienbh)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Giabanbuonchuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanbuoncovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlechuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giamuachuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giamuacovat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatriconlai).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikh).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikhnam).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Giatrikhthang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Haomonluyke).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Haomonluykedk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Madonvitinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makmcpdv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaitaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mancc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomtaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatmua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Namsx)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayghitang).HasColumnType("date");

                entity.Property(e => e.Ngaygiaonhan).HasColumnType("date");

                entity.Property(e => e.Ngayhanbaohanh).HasColumnType("date");

                entity.Property(e => e.Ngaykhauhaogannhat).HasColumnType("date");

                entity.Property(e => e.Ngaymua).HasColumnType("date");

                entity.Property(e => e.Ngayngungkh).HasColumnType("date");

                entity.Property(e => e.Ngaysudung).HasColumnType("date");

                entity.Property(e => e.Ngaytao).HasColumnType("date");

                entity.Property(e => e.Ngaytinhkh).HasColumnType("date");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguyengia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Nuocsx)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phukien)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Quycach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Sobbbangiao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sohieutaisan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sophieubaohanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tentaisan).HasMaxLength(200);

                entity.Property(e => e.Tkchiphi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tkkhauhao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tknguyengia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tylekhnam).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylekhthang).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<TsTaisanct>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mataisan, e.Mataisanphu });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisanphu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giatri).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Tuyenduong>(entity =>
            {
                entity.HasKey(e => new { e.Matuyen, e.Madonvi });

                entity.Property(e => e.Matuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Sdtnguoigiansat)
                    .HasColumnName("SDTnguoigiansat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tentuyen)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<VSxTonghopNlLenhsx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SX_TONGHOP_NL_LENHSX");

                entity.Property(e => e.Dinhluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Donvile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ghichu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Hieusuat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Mactpk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madondat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhangthaythe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malenhsx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthithaythe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathanhpham)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quycach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Soluongthanhpham).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.SumSoluong).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Tenct)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Tendaydu).HasMaxLength(300);

                entity.Property(e => e.Tenviettat).HasMaxLength(250);

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<VSxTonghopnhapthanhpham>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SX_TONGHOPNHAPTHANHPHAM");

                entity.Property(e => e.Madondat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malenhsx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<VSxTonghopxuatnl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SX_TONGHOPXUATNL");

                entity.Property(e => e.Madondat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malenhsx)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.Soluongcan).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Soluongchenhlech).HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<VTsKhauhao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TS_KHAUHAO");

                entity.Property(e => e.Giatriconlai).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Haomonluyke).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaitaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomtaisan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaykhauhaogannhat).HasColumnType("date");

                entity.Property(e => e.Tentaisan).HasMaxLength(200);
            });

            modelBuilder.Entity<VVtTonghopnhapncc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VT_TONGHOPNHAPNCC");

                entity.Property(e => e.Madondat).HasMaxLength(50);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<VVtTonghopxuatdondat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VT_TONGHOPXUATDONDAT");

                entity.Property(e => e.Madondat).HasMaxLength(50);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<VXdDinhmuc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XD_DINHMUC");

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Heso).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maplv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathanhpham)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 13)");

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<VXdTonghopcongviecphatsinh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XD_TONGHOPCONGVIECPHATSINH");

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.Tencongtrinh).HasMaxLength(200);

                entity.Property(e => e.Tendaydu).HasMaxLength(200);
            });

            modelBuilder.Entity<VXdTonghopnhapvtcongtrinh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XD_TONGHOPNHAPVTCONGTRINH");

                entity.Property(e => e.Macongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<VXdTonghopnhapvtthicong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XD_TONGHOPNHAPVTTHICONG");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathicong)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<VXdTonghopvattucongtrinh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XD_TONGHOPVATTUCONGTRINH");

                entity.Property(e => e.Dinhluong).HasColumnType("decimal(38, 13)");

                entity.Property(e => e.Donvile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ghichu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Heso).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Khoiluong).HasColumnType("decimal(28, 8)");

                entity.Property(e => e.Macongtrinh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Macongviec)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madutoan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quycach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.SumSoluong).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Tencongtrinh).HasMaxLength(200);

                entity.Property(e => e.Tendaydu).HasMaxLength(300);

                entity.Property(e => e.Tenhangmuc).HasMaxLength(200);

                entity.Property(e => e.Tennhomhang).HasMaxLength(150);

                entity.Property(e => e.Tenviettat).HasMaxLength(250);

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<VXdTonghopvattuphatsinh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XD_TONGHOPVATTUPHATSINH");

                entity.Property(e => e.Dinhluong).HasColumnType("decimal(38, 13)");

                entity.Property(e => e.Donvile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ghichu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Heso).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Khoiluong).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.Macongtrinh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Macongviec)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mactpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madutoan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahangmuc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quycach).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.SumSoluong).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Tencongtrinh).HasMaxLength(200);

                entity.Property(e => e.Tendaydu).HasMaxLength(300);

                entity.Property(e => e.Tenhangmuc).HasMaxLength(200);

                entity.Property(e => e.Tennhomhang).HasMaxLength(150);

                entity.Property(e => e.Tenviettat).HasMaxLength(250);

                entity.Property(e => e.Tilehaohut).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.HasKey(e => new { e.Mavat, e.Madonvi });

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Doanhso)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysua)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenvat).HasMaxLength(100);

                entity.Property(e => e.Vat1).HasColumnName("Vat");
            });

            modelBuilder.Entity<VtBaoduongxe>(entity =>
            {
                entity.HasKey(e => new { e.Maxe, e.Maloaibaoduong, e.Madonvi });

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaibaoduong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydenhan).HasColumnType("datetime");

                entity.Property(e => e.Ngayhieuluc).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VtDinhmucthuexe>(entity =>
            {
                entity.HasKey(e => e.Maxe);

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.SotienvuottrenKm).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Sotienvuottrengio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VtGiaodichthuexe>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodich });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodich)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Ghichuloaithechap).HasMaxLength(200);

                entity.Property(e => e.Loaithechapso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mahinhthucthanhtoan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhachhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaithechap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tungay).HasColumnType("datetime");

                entity.Property(e => e.Tuyenduong)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<VtGiaodichthuexect>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodich, e.Maxe });

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodich)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dongia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DongiaphutroitheoGio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DongiaphutroitheoKm).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Ngaygiaoxe).HasColumnType("datetime");

                entity.Property(e => e.Ngaytraxe).HasColumnType("datetime");

                entity.Property(e => e.Tienquagio).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Tienthuexe).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TienvuotKm).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Tongtien).HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<VtLichdixe>(entity =>
            {
                entity.HasKey(e => new { e.Malichxe, e.Madonvi });

                entity.Property(e => e.Malichxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Manhanvienlaixe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Thuditrongtuan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tuyenduong)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VtLoaibaoduong>(entity =>
            {
                entity.HasKey(e => new { e.Maloaibaoduong, e.Madonvi });

                entity.Property(e => e.Maloaibaoduong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maloaichuky)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaibaoduong).HasMaxLength(250);
            });

            modelBuilder.Entity<VtLoaichukybaoduong>(entity =>
            {
                entity.HasKey(e => new { e.Maloaichuky, e.Madonvi });

                entity.Property(e => e.Maloaichuky)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaichuky).HasMaxLength(250);

                entity.Property(e => e.Tylevuotchophep).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<VtLoaithechap>(entity =>
            {
                entity.HasKey(e => new { e.Maloaithechap, e.Madonvi });

                entity.Property(e => e.Maloaithechap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaithechap).HasMaxLength(250);
            });

            modelBuilder.Entity<VtThuonghieu>(entity =>
            {
                entity.HasKey(e => new { e.Mathuonghieu, e.Madonvi });

                entity.Property(e => e.Mathuonghieu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenthuonghieu).HasMaxLength(250);
            });

            modelBuilder.Entity<VtVaynganhang>(entity =>
            {
                entity.HasKey(e => new { e.Maxe, e.Madonvi })
                    .HasName("PK_VtVaynganhang_1");

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayhieuluc).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

                entity.Property(e => e.Sothangtra).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Sotienconlai).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Sotientratheothang).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Sotienvay).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Taikhoangiaodich).HasMaxLength(100);

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tendangnhapsua)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VtXe>(entity =>
            {
                entity.HasKey(e => new { e.Maxe, e.Madonvi });

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bienkiemsoat)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dongiathue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Giaydangkyso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Manhacungcap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mathuonghieu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mauson).HasMaxLength(250);

                entity.Property(e => e.Sokhung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Somay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VtXetaitrohang>(entity =>
            {
                entity.HasKey(e => new { e.Maxe, e.Madonvi });

                entity.Property(e => e.Maxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Biensoxe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(500);

                entity.Property(e => e.Nguoisua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tongsokhoi).HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Tongtrongluong).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Vuviec>(entity =>
            {
                entity.HasKey(e => new { e.Mavuviec, e.Madonvi })
                    .HasName("PK_vuviec");

                entity.Property(e => e.Mavuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomvuviec)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenvuviec).HasMaxLength(250);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Vuviec)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vuviec_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Vuviec)
                    .HasForeignKey(d => new { d.Manhomvuviec, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vuviec_Nhomvuviec");
            });

            modelBuilder.Entity<Xacnhanhoadon>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodich, e.Madonvi });

                entity.Property(e => e.Magiaodich)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manguoixacnhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvgiaohang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manvlaixe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayxacnhan).HasColumnType("datetime");

                entity.Property(e => e.Sohoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tongtienhoadon).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<XntTaisan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("XNT_TAISAN");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maphongban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mataisan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayhoachtoan).HasColumnType("date");

                entity.Property(e => e.Tonslcuoiky).HasColumnType("decimal(38, 8)");
            });

            modelBuilder.Entity<Yt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("yt");

                entity.Property(e => e.XCount).HasColumnName("xCount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
