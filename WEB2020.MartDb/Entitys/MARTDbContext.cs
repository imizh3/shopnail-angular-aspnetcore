using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class MARTDbContext : DbContext
    {
        public MARTDbContext()
        {
        }

        public MARTDbContext(DbContextOptions<MARTDbContext> options)
            : base(options)
        {
        }

        protected virtual string _connect { get; set; }

        public void SetConnect(string str)
        {
            _connect = str;
        }

        public virtual DbSet<Bangkethuegtgt> Bangkethuegtgts { get; set; }
        public virtual DbSet<Bangkethuegtgtct> Bangkethuegtgtcts { get; set; }
        public virtual DbSet<Bangketien> Bangketiens { get; set; }
        public virtual DbSet<Bangmau> Bangmaus { get; set; }
        public virtual DbSet<Banlect> Banlects { get; set; }
        public virtual DbSet<Baogiact> Baogiacts { get; set; }
        public virtual DbSet<Baogium> Baogia { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<Bohang> Bohangs { get; set; }
        public virtual DbSet<Bohangct> Bohangcts { get; set; }
        public virtual DbSet<Capma> Capmas { get; set; }
        public virtual DbSet<Capmatudong> Capmatudongs { get; set; }
        public virtual DbSet<Checkgiaodichquay> Checkgiaodichquays { get; set; }
        public virtual DbSet<Checkgiaodichquayct> Checkgiaodichquaycts { get; set; }
        public virtual DbSet<CreateKey> CreateKeys { get; set; }
        public virtual DbSet<Ctugoc> Ctugocs { get; set; }
        public virtual DbSet<Dathang> Dathangs { get; set; }
        public virtual DbSet<Dathangct> Dathangcts { get; set; }
        public virtual DbSet<Denghithanhtoan> Denghithanhtoans { get; set; }
        public virtual DbSet<Denghithanhtoanct> Denghithanhtoancts { get; set; }
        public virtual DbSet<Dinhmucdathang> Dinhmucdathangs { get; set; }
        public virtual DbSet<Dinhmucdathangnoibo> Dinhmucdathangnoibos { get; set; }
        public virtual DbSet<DmCachdonggoi> DmCachdonggois { get; set; }
        public virtual DbSet<DmCongtrinh> DmCongtrinhs { get; set; }
        public virtual DbSet<DmDinhmucnguyenlieu> DmDinhmucnguyenlieus { get; set; }
        public virtual DbSet<DmHangmuccongtrinh> DmHangmuccongtrinhs { get; set; }
        public virtual DbSet<DmKheuoc> DmKheuocs { get; set; }
        public virtual DbSet<DmLoaicongtrinh> DmLoaicongtrinhs { get; set; }
        public virtual DbSet<DmMahaiquan> DmMahaiquans { get; set; }
        public virtual DbSet<DmVanchuyen> DmVanchuyens { get; set; }
        public virtual DbSet<Dmchinhanhnganhang> Dmchinhanhnganhangs { get; set; }
        public virtual DbSet<Dmchungtu> Dmchungtus { get; set; }
        public virtual DbSet<Dmloaichungtu> Dmloaichungtus { get; set; }
        public virtual DbSet<Dmloaitk> Dmloaitks { get; set; }
        public virtual DbSet<Dmnganhang> Dmnganhangs { get; set; }
        public virtual DbSet<Dmnhomptnx> Dmnhomptnxes { get; set; }
        public virtual DbSet<Dmptnx> Dmptnxes { get; set; }
        public virtual DbSet<Dmtaikhoanketchuyen> Dmtaikhoanketchuyens { get; set; }
        public virtual DbSet<Dmtaikhoanketchuyenct> Dmtaikhoanketchuyencts { get; set; }
        public virtual DbSet<Dmtieuchuan> Dmtieuchuans { get; set; }
        public virtual DbSet<Dmtk> Dmtks { get; set; }
        public virtual DbSet<Dmtknganhang> Dmtknganhangs { get; set; }
        public virtual DbSet<Dondat> Dondats { get; set; }
        public virtual DbSet<Dondatct> Dondatcts { get; set; }
        public virtual DbSet<Donvi> Donvis { get; set; }
        public virtual DbSet<Donvitinh> Donvitinhs { get; set; }
        public virtual DbSet<Dutoan> Dutoans { get; set; }
        public virtual DbSet<Dutoanct> Dutoancts { get; set; }
        public virtual DbSet<Giaodich> Giaodiches { get; set; }
        public virtual DbSet<GiaodichLinkQuy> GiaodichLinkQuies { get; set; }
        public virtual DbSet<Giaodichcktrathuong> Giaodichcktrathuongs { get; set; }
        public virtual DbSet<Giaodichct> Giaodichcts { get; set; }
        public virtual DbSet<Giaodichctkhuyenmai> Giaodichctkhuyenmais { get; set; }
        public virtual DbSet<Giaodichcttaikhoan> Giaodichcttaikhoans { get; set; }
        public virtual DbSet<Giaodichdongop> Giaodichdongops { get; set; }
        public virtual DbSet<Giaodichgiaonhan> Giaodichgiaonhans { get; set; }
        public virtual DbSet<Giaodichgiaonhanct> Giaodichgiaonhancts { get; set; }
        public virtual DbSet<Giaodichhaiquan> Giaodichhaiquans { get; set; }
        public virtual DbSet<Giaodichphanbo> Giaodichphanbos { get; set; }
        public virtual DbSet<Giaodichphanboct> Giaodichphanbocts { get; set; }
        public virtual DbSet<Giaodichquay> Giaodichquays { get; set; }
        public virtual DbSet<Giaodichquayamct> Giaodichquayamcts { get; set; }
        public virtual DbSet<Giaodichquayct> Giaodichquaycts { get; set; }
        public virtual DbSet<Giaodichtondau> Giaodichtondaus { get; set; }
        public virtual DbSet<Giaodichtondauct> Giaodichtondaucts { get; set; }
        public virtual DbSet<Giaodichweb> Giaodichwebs { get; set; }
        public virtual DbSet<Giaodichwebct> Giaodichwebcts { get; set; }
        public virtual DbSet<Gopmavattu> Gopmavattus { get; set; }
        public virtual DbSet<GridSetting> GridSettings { get; set; }
        public virtual DbSet<Kehang> Kehangs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Khachhanggium> Khachhanggia { get; set; }
        public virtual DbSet<Khachhangtt> Khachhangtts { get; set; }
        public virtual DbSet<Khohang> Khohangs { get; set; }
        public virtual DbSet<Khohanggium> Khohanggia { get; set; }
        public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }
        public virtual DbSet<Khuyenmaict> Khuyenmaicts { get; set; }
        public virtual DbSet<Khuyenmaihangban> Khuyenmaihangbans { get; set; }
        public virtual DbSet<Khuyenmaihangkm> Khuyenmaihangkms { get; set; }
        public virtual DbSet<Kichthuocsp> Kichthuocsps { get; set; }
        public virtual DbSet<Kiemke> Kiemkes { get; set; }
        public virtual DbSet<Kiemkect> Kiemkects { get; set; }
        public virtual DbSet<Kmchiphi> Kmchiphis { get; set; }
        public virtual DbSet<LichDathang> LichDathangs { get; set; }
        public virtual DbSet<Lichsugiaodichgopdon> Lichsugiaodichgopdons { get; set; }
        public virtual DbSet<Loaikhachhang> Loaikhachhangs { get; set; }
        public virtual DbSet<Loaikhohang> Loaikhohangs { get; set; }
        public virtual DbSet<Macandientu> Macandientus { get; set; }
        public virtual DbSet<Mahshaiquan> Mahshaiquans { get; set; }
        public virtual DbSet<MartLog> MartLogs { get; set; }
        public virtual DbSet<Mathang> Mathangs { get; set; }
        public virtual DbSet<MathangSerial> MathangSerials { get; set; }
        public virtual DbSet<Mathanggiaban> Mathanggiabans { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menunhomquyen> Menunhomquyens { get; set; }
        public virtual DbSet<Nganhhang> Nganhhangs { get; set; }
        public virtual DbSet<Ngayphatsinh> Ngayphatsinhs { get; set; }
        public virtual DbSet<Ngoaite> Ngoaites { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Nhanvienkhachhang> Nhanvienkhachhangs { get; set; }
        public virtual DbSet<Nhomhang> Nhomhangs { get; set; }
        public virtual DbSet<Nhomkhachhang> Nhomkhachhangs { get; set; }
        public virtual DbSet<Nhomkmchiphi> Nhomkmchiphis { get; set; }
        public virtual DbSet<Nhomquyen> Nhomquyens { get; set; }
        public virtual DbSet<Nhomquyenphu> Nhomquyenphus { get; set; }
        public virtual DbSet<Nhomvattu> Nhomvattus { get; set; }
        public virtual DbSet<Nhomvuviec> Nhomvuviecs { get; set; }
        public virtual DbSet<NsBangchamcong> NsBangchamcongs { get; set; }
        public virtual DbSet<NsBangchamcongct> NsBangchamcongcts { get; set; }
        public virtual DbSet<NsBangluong> NsBangluongs { get; set; }
        public virtual DbSet<NsBangluongct> NsBangluongcts { get; set; }
        public virtual DbSet<NsBangluongphat> NsBangluongphats { get; set; }
        public virtual DbSet<NsBangluongphucap> NsBangluongphucaps { get; set; }
        public virtual DbSet<NsBangluongthuong> NsBangluongthuongs { get; set; }
        public virtual DbSet<NsBaohiem> NsBaohiems { get; set; }
        public virtual DbSet<NsBaohiemnhanvien> NsBaohiemnhanviens { get; set; }
        public virtual DbSet<NsBophan> NsBophans { get; set; }
        public virtual DbSet<NsCalamviec> NsCalamviecs { get; set; }
        public virtual DbSet<NsChucvu> NsChucvus { get; set; }
        public virtual DbSet<NsChuyenbophan> NsChuyenbophans { get; set; }
        public virtual DbSet<NsCongthuctinhluong> NsCongthuctinhluongs { get; set; }
        public virtual DbSet<NsDangkylamthem> NsDangkylamthems { get; set; }
        public virtual DbSet<NsDangkylamthemct> NsDangkylamthemcts { get; set; }
        public virtual DbSet<NsDangkynghi> NsDangkynghis { get; set; }
        public virtual DbSet<NsDangkynghict> NsDangkynghicts { get; set; }
        public virtual DbSet<NsDinhmucluong> NsDinhmucluongs { get; set; }
        public virtual DbSet<NsGanlichlamviec> NsGanlichlamviecs { get; set; }
        public virtual DbSet<NsKhenthuongkyluat> NsKhenthuongkyluats { get; set; }
        public virtual DbSet<NsLichlamviec> NsLichlamviecs { get; set; }
        public virtual DbSet<NsLichlamvieccasangchieu> NsLichlamvieccasangchieus { get; set; }
        public virtual DbSet<NsLichlamviecct> NsLichlamvieccts { get; set; }
        public virtual DbSet<NsLichlamviecctthang> NsLichlamviecctthangs { get; set; }
        public virtual DbSet<NsLichlamviecthang> NsLichlamviecthangs { get; set; }
        public virtual DbSet<NsLienketnhanvien> NsLienketnhanviens { get; set; }
        public virtual DbSet<NsLuongcoban> NsLuongcobans { get; set; }
        public virtual DbSet<NsLuonghopdong> NsLuonghopdongs { get; set; }
        public virtual DbSet<NsLuonghopdongbophan> NsLuonghopdongbophans { get; set; }
        public virtual DbSet<NsLuonghopdongnhanvien> NsLuonghopdongnhanviens { get; set; }
        public virtual DbSet<NsNgaynghi> NsNgaynghis { get; set; }
        public virtual DbSet<NsPhongban> NsPhongbans { get; set; }
        public virtual DbSet<NsPhucap> NsPhucaps { get; set; }
        public virtual DbSet<NsPhucapnhanvien> NsPhucapnhanviens { get; set; }
        public virtual DbSet<NsQdkhenthuongkyluat> NsQdkhenthuongkyluats { get; set; }
        public virtual DbSet<NsQdkhenthuongkyluatct> NsQdkhenthuongkyluatcts { get; set; }
        public virtual DbSet<Number> Numbers { get; set; }
        public virtual DbSet<Phanbokhuyenmai> Phanbokhuyenmais { get; set; }
        public virtual DbSet<Phanbokhuyenmaict> Phanbokhuyenmaicts { get; set; }
        public virtual DbSet<Phanquyenhanghoa> Phanquyenhanghoas { get; set; }
        public virtual DbSet<Printsetting> Printsettings { get; set; }
        public virtual DbSet<Quayhang> Quayhangs { get; set; }
        public virtual DbSet<Quyctkt> Quyctkts { get; set; }
        public virtual DbSet<Quyctktct> Quyctktcts { get; set; }
        public virtual DbSet<Sodudauky> Sodudaukies { get; set; }
        public virtual DbSet<SxDenghilinhlieu> SxDenghilinhlieus { get; set; }
        public virtual DbSet<SxDenghilinhlieuct> SxDenghilinhlieucts { get; set; }
        public virtual DbSet<SxDenghilinhlieuctnguyenlieu> SxDenghilinhlieuctnguyenlieus { get; set; }
        public virtual DbSet<SxDmDoituongthcp> SxDmDoituongthcps { get; set; }
        public virtual DbSet<SxDmHieusuat> SxDmHieusuats { get; set; }
        public virtual DbSet<SxDmXacnhan> SxDmXacnhans { get; set; }
        public virtual DbSet<SxDmXacnhanct> SxDmXacnhancts { get; set; }
        public virtual DbSet<SxDmcongthucsx> SxDmcongthucsxes { get; set; }
        public virtual DbSet<SxDmcongthucsxct> SxDmcongthucsxcts { get; set; }
        public virtual DbSet<SxDutinhNvl> SxDutinhNvls { get; set; }
        public virtual DbSet<SxDutinhNvlct> SxDutinhNvlcts { get; set; }
        public virtual DbSet<SxHieuSuatSanPham> SxHieuSuatSanPhams { get; set; }
        public virtual DbSet<SxKehoach> SxKehoaches { get; set; }
        public virtual DbSet<SxKehoachct> SxKehoachcts { get; set; }
        public virtual DbSet<SxKygiathanh> SxKygiathanhs { get; set; }
        public virtual DbSet<SxKygiathanhct> SxKygiathanhcts { get; set; }
        public virtual DbSet<SxLenhsx> SxLenhsxes { get; set; }
        public virtual DbSet<SxLenhsxct> SxLenhsxcts { get; set; }
        public virtual DbSet<SxLenhsxctnguyenlieu> SxLenhsxctnguyenlieus { get; set; }
        public virtual DbSet<SxNvXacnhan> SxNvXacnhans { get; set; }
        public virtual DbSet<SxPhanbochiphichung> SxPhanbochiphichungs { get; set; }
        public virtual DbSet<SxPhanbochiphichungRef> SxPhanbochiphichungRefs { get; set; }
        public virtual DbSet<SxPhanbochiphichungct> SxPhanbochiphichungcts { get; set; }
        public virtual DbSet<SxTiendo> SxTiendos { get; set; }
        public virtual DbSet<Thamsohethong> Thamsohethongs { get; set; }
        public virtual DbSet<Tinhthuongnhanvienct> Tinhthuongnhanviencts { get; set; }
        public virtual DbSet<Tkdoituong> Tkdoituongs { get; set; }
        public virtual DbSet<TsGiaodich> TsGiaodiches { get; set; }
        public virtual DbSet<TsGiaodichct> TsGiaodichcts { get; set; }
        public virtual DbSet<TsKhauhao> TsKhauhaos { get; set; }
        public virtual DbSet<TsKhauhaoct> TsKhauhaocts { get; set; }
        public virtual DbSet<TsLoaitaisan> TsLoaitaisans { get; set; }
        public virtual DbSet<TsNhomtaisan> TsNhomtaisans { get; set; }
        public virtual DbSet<TsTaisan> TsTaisans { get; set; }
        public virtual DbSet<TsTaisanct> TsTaisancts { get; set; }
        public virtual DbSet<Tuyenduong> Tuyenduongs { get; set; }
        public virtual DbSet<VSxTonghopNlLenhsx> VSxTonghopNlLenhsxes { get; set; }
        public virtual DbSet<VSxTonghopnhapthanhpham> VSxTonghopnhapthanhphams { get; set; }
        public virtual DbSet<VSxTonghopxuatnl> VSxTonghopxuatnls { get; set; }
        public virtual DbSet<VTsKhauhao> VTsKhauhaos { get; set; }
        public virtual DbSet<VVtTonghopnhapncc> VVtTonghopnhapnccs { get; set; }
        public virtual DbSet<VVtTonghopxuatdondat> VVtTonghopxuatdondats { get; set; }
        public virtual DbSet<VXdDinhmuc> VXdDinhmucs { get; set; }
        public virtual DbSet<VXdTonghopcongviecphatsinh> VXdTonghopcongviecphatsinhs { get; set; }
        public virtual DbSet<VXdTonghopnhapvtcongtrinh> VXdTonghopnhapvtcongtrinhs { get; set; }
        public virtual DbSet<VXdTonghopnhapvtthicong> VXdTonghopnhapvtthicongs { get; set; }
        public virtual DbSet<VXdTonghopvattucongtrinh> VXdTonghopvattucongtrinhs { get; set; }
        public virtual DbSet<VXdTonghopvattuphatsinh> VXdTonghopvattuphatsinhs { get; set; }
        public virtual DbSet<Vat> Vats { get; set; }
        public virtual DbSet<VtBaoduongxe> VtBaoduongxes { get; set; }
        public virtual DbSet<VtDinhmucthuexe> VtDinhmucthuexes { get; set; }
        public virtual DbSet<VtGiaodichthuexe> VtGiaodichthuexes { get; set; }
        public virtual DbSet<VtGiaodichthuexect> VtGiaodichthuexects { get; set; }
        public virtual DbSet<VtLichdixe> VtLichdicese { get; set; }
        public virtual DbSet<VtLoaibaoduong> VtLoaibaoduongs { get; set; }
        public virtual DbSet<VtLoaichukybaoduong> VtLoaichukybaoduongs { get; set; }
        public virtual DbSet<VtLoaithechap> VtLoaithechaps { get; set; }
        public virtual DbSet<VtThuonghieu> VtThuonghieus { get; set; }
        public virtual DbSet<VtVaynganhang> VtVaynganhangs { get; set; }
        public virtual DbSet<VtXe> VtXes { get; set; }
        public virtual DbSet<VtXetaitrohang> VtXetaitrohangs { get; set; }
        public virtual DbSet<Vuviec> Vuviecs { get; set; }
        public virtual DbSet<Xacnhanhoadon> Xacnhanhoadons { get; set; }
        public virtual DbSet<XntTaisan> XntTaisans { get; set; }
        public virtual DbSet<Yt> Yts { get; set; }

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bangkethuegtgt>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mabangke })
                    .HasName("PK_Bangkethuegtgt_1");

                entity.ToTable("Bangkethuegtgt");

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

                entity.ToTable("Bangkethuegtgtct");

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
                entity.ToTable("Bangketien");

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

                entity.ToTable("Bangmau");

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

                entity.ToTable("Banlect");

                entity.Property(e => e.Giabanlecovat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Giavon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Laivon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tban)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TBan");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tienlai).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tvon)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TVon");

                entity.Property(e => e.Tylelaile).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Baogiact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Baogiact");

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

            modelBuilder.Entity<Baogium>(entity =>
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

            modelBuilder.Entity<Barcode>(entity =>
            {
                entity.HasKey(e => new { e.Barcode1, e.Madonvi })
                    .HasName("PK_Barcode_1");

                entity.ToTable("Barcode");

                entity.Property(e => e.Barcode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Barcode");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Barcodes)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Barcode_Donvi");
            });

            modelBuilder.Entity<Bohang>(entity =>
            {
                entity.HasKey(e => new { e.Mabohang, e.Madonvi });

                entity.ToTable("Bohang");

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
                    .WithMany(p => p.Bohangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohang_Donvi");
            });

            modelBuilder.Entity<Bohangct>(entity =>
            {
                entity.HasKey(e => new { e.Mabohang, e.Madonvi, e.Masieuthi });

                entity.ToTable("Bohangct");

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
                    .WithMany(p => p.Bohangcts)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohangct_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Bohangcts)
                    .HasForeignKey(d => new { d.Mabohang, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohangct_Bohang");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Bohangcts)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bohangct_Mathang");
            });

            modelBuilder.Entity<Capma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Capma");

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

                entity.ToTable("Capmatudong");

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

                entity.ToTable("Checkgiaodichquay");

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

                entity.ToTable("Checkgiaodichquayct");

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

                entity.Property(e => e.Soluongnhap).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tensieuthi)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<CreateKey>(entity =>
            {
                entity.HasKey(e => e.IdKey);

                entity.ToTable("CreateKey");

                entity.Property(e => e.IdKey)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("idKey");

                entity.Property(e => e.Date)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.IdKhachhang)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("idKhachhang");

                entity.Property(e => e.PhanHe)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("phanHe");

                entity.Property(e => e.SoMay)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("soMay");

                entity.Property(e => e.Time)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("trangThai");
            });

            modelBuilder.Entity<Ctugoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ctugoc");

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

                entity.ToTable("Dathang");

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
                    .WithMany(p => p.Dathangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathang_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Dathangs)
                    .HasForeignKey(d => new { d.Maptnx, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dathang_Dmptnx");
            });

            modelBuilder.Entity<Dathangct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dathangct");

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

                entity.ToTable("Denghithanhtoan");

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
                    .WithMany(p => p.Denghithanhtoans)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Denghithanhtoan_Donvi");
            });

            modelBuilder.Entity<Denghithanhtoanct>(entity =>
            {
                entity.ToTable("Denghithanhtoanct");

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

                entity.ToTable("Dinhmucdathang");

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

                entity.ToTable("Dinhmucdathangnoibo");

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

                entity.ToTable("DmCachdonggoi");

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

                entity.ToTable("DmCongtrinh");

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
                    .WithMany(p => p.DmCongtrinhs)
                    .HasForeignKey(d => new { d.Madonvi, d.Maloaicongtrinh })
                    .HasConstraintName("FK_DmCongtrinh_DmLoaicongtrinh");
            });

            modelBuilder.Entity<DmDinhmucnguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Mactpk, e.Masieuthi });

                entity.ToTable("DmDinhmucnguyenlieu");

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

                entity.ToTable("DmHangmuccongtrinh");

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

                entity.ToTable("DmKheuoc");

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

                entity.ToTable("DmLoaicongtrinh");

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

                entity.ToTable("DmMahaiquan");

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

                entity.ToTable("DmVanchuyen");

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

                entity.ToTable("Dmchinhanhnganhang");

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
                    .WithMany(p => p.Dmchinhanhnganhangs)
                    .HasForeignKey(d => d.Manganhang)
                    .HasConstraintName("FK_Dmchinhanhnganhang_Dmnganhang");
            });

            modelBuilder.Entity<Dmchungtu>(entity =>
            {
                entity.HasKey(e => new { e.Mactu, e.Madonvi })
                    .HasName("PK_TDS_Dmchungtu");

                entity.ToTable("Dmchungtu");

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
                    .WithMany(p => p.Dmchungtus)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmchungtu_Donvi");

                entity.HasOne(d => d.MaloaictuNavigation)
                    .WithMany(p => p.Dmchungtus)
                    .HasForeignKey(d => d.Maloaictu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmchungtu_Dmloaichungtu");
            });

            modelBuilder.Entity<Dmloaichungtu>(entity =>
            {
                entity.HasKey(e => e.Maloaictu)
                    .HasName("PK_TDS_Dmloaichungtu");

                entity.ToTable("Dmloaichungtu");

                entity.Property(e => e.Maloaictu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaictu).HasMaxLength(150);
            });

            modelBuilder.Entity<Dmloaitk>(entity =>
            {
                entity.HasKey(e => e.Maloaitk)
                    .HasName("PK_TDS_Dmloaitk");

                entity.ToTable("Dmloaitk");

                entity.Property(e => e.Maloaitk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tenloaitk).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmnganhang>(entity =>
            {
                entity.HasKey(e => e.Manganhang);

                entity.ToTable("Dmnganhang");

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

                entity.ToTable("Dmnhomptnx");

                entity.Property(e => e.Manhomptnx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Tennhomptnx).HasMaxLength(200);
            });

            modelBuilder.Entity<Dmptnx>(entity =>
            {
                entity.HasKey(e => new { e.Maptnx, e.Madonvi });

                entity.ToTable("Dmptnx");

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
                    .WithMany(p => p.Dmptnxes)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmptnx_Donvi");

                entity.HasOne(d => d.ManhomptnxNavigation)
                    .WithMany(p => p.Dmptnxes)
                    .HasForeignKey(d => d.Manhomptnx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmptnx_Dmnhomptnx");
            });

            modelBuilder.Entity<Dmtaikhoanketchuyen>(entity =>
            {
                entity.HasKey(e => new { e.Matkketchuyen, e.Madonvi });

                entity.ToTable("Dmtaikhoanketchuyen");

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

                entity.ToTable("Dmtaikhoanketchuyenct");

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

                entity.ToTable("Dmtieuchuan");

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

                entity.ToTable("Dmtk");

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
                    .WithMany(p => p.Dmtks)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmtk_Donvi");

                entity.HasOne(d => d.MaloaitkNavigation)
                    .WithMany(p => p.Dmtks)
                    .HasForeignKey(d => d.Maloaitk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dmtk_Dmloaitk");
            });

            modelBuilder.Entity<Dmtknganhang>(entity =>
            {
                entity.HasKey(e => e.Taikhoan);

                entity.ToTable("Dmtknganhang");

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

                entity.ToTable("Dondat");

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachigiaohang).HasMaxLength(250);

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

                entity.ToTable("Dondatct");

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

                entity.ToTable("Donvi");

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

                entity.ToTable("Donvitinh");

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

                entity.Property(e => e.Madonvile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvilon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Donvitinhs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donvitinh_Donvi");

                entity.HasOne(d => d.Nguoidung)
                    .WithMany(p => p.Donvitinhs)
                    .HasForeignKey(d => new { d.Madonvi, d.Tendangnhap })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donvitinh_Nguoidung");
            });

            modelBuilder.Entity<Dutoan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Madutoan });

                entity.ToTable("Dutoan");

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

                entity.ToTable("Dutoanct");

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

                entity.ToTable("Giaodich");

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

                entity.Property(e => e.Keyhoadondientu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kyhieuhoadon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphu).HasMaxLength(50);

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

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

                entity.Property(e => e.Tyleckthanhtoanngay).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Giaodiches)
                    .HasForeignKey(d => new { d.Maptnx, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodich_Dmptnx");
            });

            modelBuilder.Entity<GiaodichLinkQuy>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Mactktpk });

                entity.ToTable("GiaodichLinkQuy");

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
                entity.HasNoKey();

                entity.ToTable("Giaodichcktrathuong");

                entity.Property(e => e.Iskhachhang).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mactktpk)
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

                entity.Property(e => e.Manganh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Masieuthi)
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

                entity.ToTable("Giaodichct");

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

                entity.Property(e => e.Madvtinh)
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
                entity.ToTable("Giaodichctkhuyenmai");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

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

                entity.ToTable("Giaodichcttaikhoan");

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

                entity.ToTable("Giaodichdongop");

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

                entity.Property(e => e.Nganhhangdain)
                    .HasMaxLength(100)
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

                entity.ToTable("Giaodichgiaonhan");

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

                entity.ToTable("Giaodichgiaonhanct");

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
                    .WithMany(p => p.Giaodichgiaonhancts)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichgiaonhanct_Giaodichgiaonhan");
            });

            modelBuilder.Entity<Giaodichhaiquan>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.ToTable("Giaodichhaiquan");

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
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOCMND");

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
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichphanbo });

                entity.ToTable("Giaodichphanbo");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphanbo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(250);

                entity.Property(e => e.Magiaodichpk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mangoaite)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh).HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.Tendangnhap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");
            });

            modelBuilder.Entity<Giaodichphanboct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Giaodichphanboct");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Magiaodichphanbo)
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

                entity.Property(e => e.Sotien).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.Sotiennt).HasColumnType("decimal(18, 7)");
            });

            modelBuilder.Entity<Giaodichquay>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.ToTable("Giaodichquay");

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
                    .WithMany(p => p.Giaodichquays)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquay_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Giaodichquays)
                    .HasForeignKey(d => new { d.Maptnx, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquay_Dmptnx");
            });

            modelBuilder.Entity<Giaodichquayamct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Masieuthi, e.Makhohang, e.Mabohang });

                entity.ToTable("Giaodichquayamct");

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

                entity.ToTable("Giaodichquayct");

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
                    .WithMany(p => p.Giaodichquaycts)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquayct_Giaodichquay");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Giaodichquaycts)
                    .HasForeignKey(d => new { d.Makhohang, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquayct_Khohang");

                entity.HasOne(d => d.Ma1)
                    .WithMany(p => p.Giaodichquaycts)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichquayct_Mathang");
            });

            modelBuilder.Entity<Giaodichtondau>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.ToTable("Giaodichtondau");

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

                entity.ToTable("Giaodichtondauct");

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

            modelBuilder.Entity<Giaodichweb>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.ToTable("Giaodichweb");

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
                    .IsFixedLength(true);

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

                entity.Property(e => e.Ngaytao).HasColumnType("datetime");

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
            });

            modelBuilder.Entity<Giaodichwebct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Giaodichwebct");

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Doanhthunt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiachuavat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiachuavatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Dongiacovat).HasColumnType("decimal(20, 8)");

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

                entity.Property(e => e.Giavon).HasColumnType("decimal(20, 8)");

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

                entity.Property(e => e.Mamau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.Mavat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavatnk)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mavuviec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soluong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Thanhtiennt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphikhac).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphikhacnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphivc).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienchiphivcnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencknt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrathuong).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrathuongnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tiencktrendonnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhang).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhangnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienhangtinhthue).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvat).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatnk).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatnknt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tienvatnt).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tygia).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tyleck).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylecktrendon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelaibuon).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Tylelaile).HasColumnType("decimal(20, 8)");

                entity.HasOne(d => d.Ma)
                    .WithMany()
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giaodichwebct_Giaodichweb");
            });

            modelBuilder.Entity<Gopmavattu>(entity =>
            {
                entity.ToTable("Gopmavattu");

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

                entity.ToTable("GridSetting");

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

                entity.ToTable("Kehang");

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

                entity.ToTable("Khachhang");

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
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khachhang_Donvi");
            });

            modelBuilder.Entity<Khachhanggium>(entity =>
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

                entity.ToTable("Khachhangtt");

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

                entity.ToTable("Khohang");

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
                    .WithMany(p => p.Khohangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khohang_Donvi");
            });

            modelBuilder.Entity<Khohanggium>(entity =>
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

                entity.ToTable("Khuyenmai");

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
                    .WithMany(p => p.Khuyenmais)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Khuyenmai_Donvi");
            });

            modelBuilder.Entity<Khuyenmaict>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("Khuyenmaict");

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
                    .WithMany(p => p.Khuyenmaicts)
                    .HasForeignKey(d => d.Madonvi)
                    .HasConstraintName("FK_Khuyenmaict_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Khuyenmaicts)
                    .HasForeignKey(d => new { d.Machuongtrinh, d.Madonvi })
                    .HasConstraintName("FK_Khuyenmaict_Khuyenmai");
            });

            modelBuilder.Entity<Khuyenmaihangban>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Madonvi });

                entity.ToTable("Khuyenmaihangban");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doituongapdung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohangban)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Khuyenmaihangkm>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Madonvi });

                entity.ToTable("Khuyenmaihangkm");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giatrikm).HasColumnType("decimal(20, 8)");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makhohangkm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Makmban)
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

                entity.ToTable("Kichthuocsp");

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

                entity.ToTable("Kiemke");

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
                    .WithMany(p => p.Kiemkes)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kiemke_Donvi");
            });

            modelBuilder.Entity<Kiemkect>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.ToTable("Kiemkect");

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
                    .WithMany(p => p.Kiemkects)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kiemkect_Kiemke");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Kiemkects)
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .HasConstraintName("FK_Kiemkect_Nganhhang");

                entity.HasOne(d => d.Ma1)
                    .WithMany(p => p.Kiemkects)
                    .HasForeignKey(d => new { d.Manhomhang, d.Madonvi })
                    .HasConstraintName("FK_Kiemkect_Nhomhang");

                entity.HasOne(d => d.Ma2)
                    .WithMany(p => p.Kiemkects)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kiemkect_Mathang");
            });

            modelBuilder.Entity<Kmchiphi>(entity =>
            {
                entity.HasKey(e => new { e.Makmchiphi, e.Madonvi })
                    .HasName("PK_TDS_Kmchiphi");

                entity.ToTable("Kmchiphi");

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
                    .WithMany(p => p.Kmchiphis)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kmchiphi_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Kmchiphis)
                    .HasForeignKey(d => new { d.Manhomkmchiphi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kmchiphi_Nhomkmchiphi");
            });

            modelBuilder.Entity<LichDathang>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("LichDathang");

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

                entity.ToTable("Lichsugiaodichgopdon");

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

                entity.ToTable("Loaikhachhang");

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

                entity.ToTable("Loaikhohang");

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

                entity.ToTable("Macandientu");

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
                    .WithMany(p => p.Macandientus)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Macandientu_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Macandientus)
                    .HasForeignKey(d => new { d.Masieuthi, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Macandientu_Mathang");
            });

            modelBuilder.Entity<Mahshaiquan>(entity =>
            {
                entity.HasKey(e => new { e.Mahs, e.Madonvi });

                entity.ToTable("Mahshaiquan");

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
                entity.ToTable("MartLog");

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

                entity.ToTable("Mathang");

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
                    .WithMany(p => p.Mathangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Donvi");

                entity.HasOne(d => d.Mad)
                    .WithMany(p => p.Mathangs)
                    .HasForeignKey(d => new { d.Madvtinh, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Donvitinh");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Mathangs)
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Nganhhang");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Mathangs)
                    .HasForeignKey(d => new { d.Manhomhang, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mathang_Nhomhang");
            });

            modelBuilder.Entity<MathangSerial>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi, e.Serial, e.Magiaodichpk });

                entity.ToTable("MathangSerial");

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
                entity.ToTable("Mathanggiaban");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

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

                entity.ToTable("Menu");

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

                entity.ToTable("Menunhomquyen");

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
                    .WithMany(p => p.Menunhomquyens)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menunhomquyen_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Menunhomquyens)
                    .HasForeignKey(d => new { d.Manhomquyen, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menunhomquyen_Nhomquyen");
            });

            modelBuilder.Entity<Nganhhang>(entity =>
            {
                entity.HasKey(e => new { e.Manganh, e.Madonvi });

                entity.ToTable("Nganhhang");

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
                    .WithMany(p => p.Nganhhangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nganhhang_Donvi");
            });

            modelBuilder.Entity<Ngayphatsinh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ngayphatsinh");

                entity.Property(e => e.Madonvi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayphatsinh1)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngayphatsinh");
            });

            modelBuilder.Entity<Ngoaite>(entity =>
            {
                entity.HasKey(e => new { e.Mangoaite, e.Madonvi });

                entity.ToTable("Ngoaite");

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

                entity.ToTable("Nguoidung");

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

                // entity.Property(e => e.Makhohang)
                //     .HasMaxLength(20)
                //     .IsUnicode(false);

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
                    .WithMany(p => p.Nguoidungs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nguoidung_Donvi");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Manhanvien, e.Madonvi });

                entity.ToTable("Nhanvien");

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
                    .HasMaxLength(500)
                    .HasColumnName("HTquanhuyen");

                entity.Property(e => e.Htsonha)
                    .HasMaxLength(500)
                    .HasColumnName("HTsonha");

                entity.Property(e => e.Htthonxom)
                    .HasMaxLength(500)
                    .HasColumnName("HTthonxom");

                entity.Property(e => e.Httinhtp)
                    .HasMaxLength(500)
                    .HasColumnName("HTtinhtp");

                entity.Property(e => e.Htxaphuong)
                    .HasMaxLength(500)
                    .HasColumnName("HTxaphuong");

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
                    .HasMaxLength(500)
                    .HasColumnName("TCquanhuyen");

                entity.Property(e => e.Tcsonha)
                    .HasMaxLength(500)
                    .HasColumnName("TCsonha");

                entity.Property(e => e.Tcthonxom)
                    .HasMaxLength(500)
                    .HasColumnName("TCthonxom");

                entity.Property(e => e.Tctinhtp)
                    .HasMaxLength(500)
                    .HasColumnName("TCtinhtp");

                entity.Property(e => e.Tcxaphuong)
                    .HasMaxLength(500)
                    .HasColumnName("TCxaphuong");

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
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_Nhanvien_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => new { d.Machucvu, d.Madonvi })
                    .HasConstraintName("FK_Nhanvien_NsChucvu");

                entity.HasOne(d => d.Ma1)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_Nhanvien_NsPhongban");
            });

            modelBuilder.Entity<Nhanvienkhachhang>(entity =>
            {
                entity.HasKey(e => new { e.Manhanvien, e.Makhachhang, e.Madonvi });

                entity.ToTable("Nhanvienkhachhang");

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

                entity.ToTable("Nhomhang");

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
                    .WithMany(p => p.Nhomhangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomhang_Donvi");

                entity.HasOne(d => d.Nguoidung)
                    .WithMany(p => p.Nhomhangs)
                    .HasForeignKey(d => new { d.Madonvi, d.Tendangnhap })
                    .HasConstraintName("FK_Nhomhang_Nguoidung");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Nhomhangs)
                    .HasForeignKey(d => new { d.Manganh, d.Madonvi })
                    .HasConstraintName("FK_Nhomhang_Nganhhang");
            });

            modelBuilder.Entity<Nhomkhachhang>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Manhomkhachhang });

                entity.ToTable("Nhomkhachhang");

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
                    .WithMany(p => p.Nhomkhachhangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomkhachhang_Donvi");
            });

            modelBuilder.Entity<Nhomkmchiphi>(entity =>
            {
                entity.HasKey(e => new { e.Manhomkmchiphi, e.Madonvi });

                entity.ToTable("Nhomkmchiphi");

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
                    .WithMany(p => p.Nhomkmchiphis)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomkmchiphi_Nhomkmchiphi");
            });

            modelBuilder.Entity<Nhomquyen>(entity =>
            {
                entity.HasKey(e => new { e.Manhomquyen, e.Madonvi });

                entity.ToTable("Nhomquyen");

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
                    .WithMany(p => p.Nhomquyens)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomquyen_Donvi");
            });

            modelBuilder.Entity<Nhomquyenphu>(entity =>
            {
                entity.HasKey(e => new { e.Manhomquyen, e.Menuid, e.Madonvi, e.Chucnangphu });

                entity.ToTable("Nhomquyenphu");

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
                    .WithMany(p => p.Nhomquyenphus)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomquyenphu_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Nhomquyenphus)
                    .HasForeignKey(d => new { d.Manhomquyen, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nhomquyenphu_Nhomquyen");
            });

            modelBuilder.Entity<Nhomvattu>(entity =>
            {
                entity.HasKey(e => new { e.Manhom, e.Madonvi });

                entity.ToTable("Nhomvattu");

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

                entity.ToTable("Nhomvuviec");

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

                entity.ToTable("NsBangchamcong");

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
                    .WithMany(p => p.NsBangchamcongs)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsBangchamcong_NsBophan");
            });

            modelBuilder.Entity<NsBangchamcongct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NsBangchamcongct");

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

                entity.ToTable("NsBangluong");

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
                    .WithMany(p => p.NsBangluongs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBangluong_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsBangluongs)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsBangluong_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsBangluongs)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsBangluong_NsPhongban");
            });

            modelBuilder.Entity<NsBangluongct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NsBangluongct");

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

                entity.ToTable("NsBangluongphat");

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

                entity.ToTable("NsBangluongphucap");

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

                entity.ToTable("NsBangluongthuong");

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

                entity.ToTable("NsBaohiem");

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
                    .WithMany(p => p.NsBaohiems)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBaohiem_Donvi");
            });

            modelBuilder.Entity<NsBaohiemnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Mabaohiem, e.Manhanvien, e.Madonvi })
                    .HasName("PK_NsBaohiemnhanvien_1");

                entity.ToTable("NsBaohiemnhanvien");

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
                    .WithMany(p => p.NsBaohiemnhanviens)
                    .HasForeignKey(d => new { d.Mabaohiem, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBaohiemnhanvien_NsBaohiem");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsBaohiemnhanviens)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBaohiemnhanvien_Nhanvien");
            });

            modelBuilder.Entity<NsBophan>(entity =>
            {
                entity.HasKey(e => new { e.Mabophan, e.Madonvi })
                    .HasName("PK_Nsbophan");

                entity.ToTable("NsBophan");

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
                    .WithMany(p => p.NsBophans)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsBophan_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsBophans)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsBophan_NsPhongban");
            });

            modelBuilder.Entity<NsCalamviec>(entity =>
            {
                entity.HasKey(e => new { e.Macalamviec, e.Madonvi })
                    .HasName("PK_Nscalamviec");

                entity.ToTable("NsCalamviec");

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
                    .WithMany(p => p.NsCalamviecs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsCalamviec_Donvi");
            });

            modelBuilder.Entity<NsChucvu>(entity =>
            {
                entity.HasKey(e => new { e.Machucvu, e.Madonvi })
                    .HasName("PK_Nschucvu");

                entity.ToTable("NsChucvu");

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
                    .WithMany(p => p.NsChucvus)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsChucvu_Donvi");
            });

            modelBuilder.Entity<NsChuyenbophan>(entity =>
            {
                entity.HasKey(e => new { e.Machuyenbophan, e.Madonvi });

                entity.ToTable("NsChuyenbophan");

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
                    .WithMany(p => p.NsChuyenbophans)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsChuyenbophan_NsChuyenbophan");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsChuyenbophans)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsChuyenbophan_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsChuyenbophans)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsChuyenbophan_Nhanvien");
            });

            modelBuilder.Entity<NsCongthuctinhluong>(entity =>
            {
                entity.HasKey(e => new { e.Macongthuc, e.Madonvi })
                    .HasName("PK_NsCongthuctinhluong_1");

                entity.ToTable("NsCongthuctinhluong");

                entity.HasIndex(e => e.Macongthuc, "IX_NsCongthuctinhluong");

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
                    .WithMany(p => p.NsCongthuctinhluongs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsCongthuctinhluong_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsCongthuctinhluongs)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsCongthuctinhluong_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsCongthuctinhluongs)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsCongthuctinhluong_NsPhongban");
            });

            modelBuilder.Entity<NsDangkylamthem>(entity =>
            {
                entity.HasKey(e => new { e.Madangkylamthem, e.Madonvi })
                    .HasName("PK_Nsdangkylamthem");

                entity.ToTable("NsDangkylamthem");

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
                    .WithMany(p => p.NsDangkylamthems)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsDangkylamthem_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsDangkylamthems)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsDangkylamthem_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsDangkylamthems)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsDangkylamthem_Nhanvien");
            });

            modelBuilder.Entity<NsDangkylamthemct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NsDangkylamthemct");

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

                entity.ToTable("NsDangkynghi");

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
                    .WithMany(p => p.NsDangkynghis)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsDangkynghi_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsDangkynghis)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsDangkynghi_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsDangkynghis)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsDangkynghi_Nhanvien");
            });

            modelBuilder.Entity<NsDangkynghict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NsDangkynghict");

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

                entity.ToTable("NsDinhmucluong");

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
                    .WithMany(p => p.NsDinhmucluongs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsDinhmucluong_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsDinhmucluongs)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .HasConstraintName("FK_NsDinhmucluong_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsDinhmucluongs)
                    .HasForeignKey(d => new { d.Maphongban, d.Madonvi })
                    .HasConstraintName("FK_NsDinhmucluong_NsPhongban");
            });

            modelBuilder.Entity<NsGanlichlamviec>(entity =>
            {
                entity.HasKey(e => new { e.Maganlichlamviec, e.Madonvi })
                    .HasName("PK_Nsganlichlamviec");

                entity.ToTable("NsGanlichlamviec");

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
                    .WithMany(p => p.NsGanlichlamviecs)
                    .HasForeignKey(d => new { d.Malichlamviec, d.Madonvi })
                    .HasConstraintName("FK_NsGanlichlamviec_NsLichlamviec");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsGanlichlamviecs)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsGanlichlamviec_Nhanvien");
            });

            modelBuilder.Entity<NsKhenthuongkyluat>(entity =>
            {
                entity.HasKey(e => new { e.Makhenthuongkyluat, e.Madonvi });

                entity.ToTable("NsKhenthuongkyluat");

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
                    .WithMany(p => p.NsKhenthuongkyluats)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsKhenthuongkyluat_Donvi");
            });

            modelBuilder.Entity<NsLichlamviec>(entity =>
            {
                entity.HasKey(e => new { e.Malichlamviec, e.Madonvi })
                    .HasName("PK_Nslichlamviec");

                entity.ToTable("NsLichlamviec");

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
                    .WithMany(p => p.NsLichlamviecs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLichlamviec_Donvi");
            });

            modelBuilder.Entity<NsLichlamvieccasangchieu>(entity =>
            {
                entity.HasKey(e => new { e.Maphongban, e.Madonvi })
                    .HasName("PK_NsLichlamvieccasangchieu_1");

                entity.ToTable("NsLichlamvieccasangchieu");

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

                entity.ToTable("NsLichlamviecct");

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

                entity.ToTable("NsLichlamviecctthang");

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

                entity.ToTable("NsLichlamviecthang");

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
                    .WithMany(p => p.NsLichlamviecthangs)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLichlamviecthang_Nhanvien");
            });

            modelBuilder.Entity<NsLienketnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Mabophanlamthem, e.Madonvi });

                entity.ToTable("NsLienketnhanvien");

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
                    .WithMany(p => p.NsLienketnhanviens)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLienketnhanvien_Donvi");
            });

            modelBuilder.Entity<NsLuongcoban>(entity =>
            {
                entity.HasKey(e => new { e.Maluongcoban, e.Madonvi })
                    .HasName("PK_Nsluongcoban");

                entity.ToTable("NsLuongcoban");

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
                    .WithMany(p => p.NsLuongcobans)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuongcoban_Donvi");
            });

            modelBuilder.Entity<NsLuonghopdong>(entity =>
            {
                entity.HasKey(e => new { e.Maluonghopdong, e.Madonvi })
                    .HasName("PK_Nsluonghopdong");

                entity.ToTable("NsLuonghopdong");

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
                    .WithMany(p => p.NsLuonghopdongs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdong_Donvi");
            });

            modelBuilder.Entity<NsLuonghopdongbophan>(entity =>
            {
                entity.HasKey(e => new { e.Maluonghopdong, e.Mabophan, e.Madonvi })
                    .HasName("PK_NsLuonghopdongnhanvien");

                entity.ToTable("NsLuonghopdongbophan");

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
                    .WithMany(p => p.NsLuonghopdongbophans)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsLuonghopdongbophans)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_NsBophan");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsLuonghopdongbophans)
                    .HasForeignKey(d => new { d.Maluonghopdong, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_NsLuonghopdong");
            });

            modelBuilder.Entity<NsLuonghopdongnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Maluonghopdong, e.Manhanvien, e.Madonvi })
                    .HasName("PK_NsLuonghopdongnhanvien_1");

                entity.ToTable("NsLuonghopdongnhanvien");

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
                    .WithMany(p => p.NsLuonghopdongnhanviens)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_Donvi1");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsLuonghopdongnhanviens)
                    .HasForeignKey(d => new { d.Maluonghopdong, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_NsLuonghopdong1");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsLuonghopdongnhanviens)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsLuonghopdongnhanvien_Nhanvien");
            });

            modelBuilder.Entity<NsNgaynghi>(entity =>
            {
                entity.HasKey(e => new { e.Mangaynghi, e.Madonvi })
                    .HasName("PK_Nsngaynghi_1");

                entity.ToTable("NsNgaynghi");

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
                    .WithMany(p => p.NsNgaynghis)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsNgaynghi_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsNgaynghis)
                    .HasForeignKey(d => new { d.Mabophan, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsNgaynghi_NsBophan");
            });

            modelBuilder.Entity<NsPhongban>(entity =>
            {
                entity.HasKey(e => new { e.Maphongban, e.Madonvi })
                    .HasName("PK_Nsphongban");

                entity.ToTable("NsPhongban");

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
                    .WithMany(p => p.NsPhongbans)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhongban_Donvi");
            });

            modelBuilder.Entity<NsPhucap>(entity =>
            {
                entity.HasKey(e => new { e.Maphucap, e.Madonvi })
                    .HasName("PK_Nsphucap");

                entity.ToTable("NsPhucap");

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
                    .WithMany(p => p.NsPhucaps)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucap_Donvi");
            });

            modelBuilder.Entity<NsPhucapnhanvien>(entity =>
            {
                entity.HasKey(e => new { e.Maphucap, e.Manhanvien, e.Madonvi })
                    .HasName("PK_Nsnhanvienphucap");

                entity.ToTable("NsPhucapnhanvien");

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
                    .WithMany(p => p.NsPhucapnhanviens)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucapnhanvien_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsPhucapnhanviens)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucapnhanvien_Nhanvien");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.NsPhucapnhanviens)
                    .HasForeignKey(d => new { d.Maphucap, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsPhucapnhanvien_NsPhucap");
            });

            modelBuilder.Entity<NsQdkhenthuongkyluat>(entity =>
            {
                entity.HasKey(e => new { e.Maquyetdinh, e.Madonvi });

                entity.ToTable("NsQdkhenthuongkyluat");

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
                    .WithMany(p => p.NsQdkhenthuongkyluats)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsQdkhenthuongkyluat_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.NsQdkhenthuongkyluats)
                    .HasForeignKey(d => new { d.Manhanvien, d.Madonvi })
                    .HasConstraintName("FK_NsQdkhenthuongkyluat_Nhanvien");
            });

            modelBuilder.Entity<NsQdkhenthuongkyluatct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NsQdkhenthuongkyluatct");

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

            modelBuilder.Entity<Number>(entity =>
            {
                entity.HasKey(e => e.Number1);

                entity.Property(e => e.Number1)
                    .ValueGeneratedNever()
                    .HasColumnName("Number");
            });

            modelBuilder.Entity<Phanbokhuyenmai>(entity =>
            {
                entity.HasKey(e => new { e.Machuongtrinh, e.Madonvi });

                entity.ToTable("Phanbokhuyenmai");

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

                entity.ToTable("Phanbokhuyenmaict");

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

                entity.ToTable("Phanquyenhanghoa");

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

                entity.ToTable("Printsetting");

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

                entity.ToTable("Quayhang");

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
                    .WithMany(p => p.Quayhangs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quayhang_Donvi");
            });

            modelBuilder.Entity<Quyctkt>(entity =>
            {
                entity.HasKey(e => new { e.Mactktpk, e.Madonvi })
                    .HasName("PK_Quyctkt_1");

                entity.ToTable("Quyctkt");

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
                    .WithMany(p => p.Quyctkts)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quyctkt_Donvi");
            });

            modelBuilder.Entity<Quyctktct>(entity =>
            {
                entity.ToTable("Quyctktct");

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

                entity.ToTable("Sodudauky");

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

                entity.ToTable("SxDenghilinhlieu");

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
                    .WithMany(p => p.SxDenghilinhlieus)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDenghilinhlieu_Donvi");
            });

            modelBuilder.Entity<SxDenghilinhlieuct>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Masieuthi });

                entity.ToTable("SxDenghilinhlieuct");

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

                entity.ToTable("SxDenghilinhlieuctnguyenlieu");

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

                entity.ToTable("SxDmDoituongthcp");

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

                entity.ToTable("SxDmHieusuat");

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

                entity.ToTable("SxDmXacnhan");

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

                entity.ToTable("SxDmXacnhanct");

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
                    .WithMany(p => p.SxDmXacnhancts)
                    .HasForeignKey(d => new { d.Maxacnhan, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDmXacnhanct_SxDmXacnhan");
            });

            modelBuilder.Entity<SxDmcongthucsx>(entity =>
            {
                entity.HasKey(e => new { e.Mactpk, e.Madonvi });

                entity.ToTable("SxDmcongthucsx");

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

                entity.ToTable("SxDmcongthucsxct");

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
                    .WithMany(p => p.SxDmcongthucsxcts)
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
                    .WithMany(p => p.SxDutinhNvlcts)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxDutinhNVLct_SxDutinhNVL");
            });

            modelBuilder.Entity<SxHieuSuatSanPham>(entity =>
            {
                entity.HasKey(e => new { e.Masieuthi, e.Madonvi })
                    .HasName("PK_SxHieuSuatSanPham_1");

                entity.ToTable("SxHieuSuatSanPham");

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

                entity.ToTable("SxKehoach");

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

                entity.ToTable("SxKehoachct");

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
                    .WithMany(p => p.SxKehoachcts)
                    .HasForeignKey(d => new { d.Magiaodichpk, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxKehoachct_SxKehoach");
            });

            modelBuilder.Entity<SxKygiathanh>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Ma });

                entity.ToTable("SxKygiathanh");

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

                entity.ToTable("SxKygiathanhct");

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
                    .WithMany(p => p.SxKygiathanhcts)
                    .HasForeignKey(d => new { d.Madonvi, d.Ma })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxKygiathanhct_SxKygiathanhct");
            });

            modelBuilder.Entity<SxLenhsx>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi });

                entity.ToTable("SxLenhsx");

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

                entity.ToTable("SxLenhsxct");

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

                entity.ToTable("SxLenhsxctnguyenlieu");

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

                entity.ToTable("SxNvXacnhan");

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
                    .WithMany(p => p.SxNvXacnhans)
                    .HasForeignKey(d => new { d.Maxacnhan, d.Madonvi })
                    .HasConstraintName("FK_SxNvXacnhan_SxDmXacnhan");
            });

            modelBuilder.Entity<SxPhanbochiphichung>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maky })
                    .HasName("PK_SxPhanbochiphichung_1");

                entity.ToTable("SxPhanbochiphichung");

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

                entity.ToTable("SxPhanbochiphichungRef");

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

                entity.ToTable("SxPhanbochiphichungct");

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
                    .WithMany(p => p.SxPhanbochiphichungcts)
                    .HasForeignKey(d => new { d.Madonvi, d.Maky })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SxPhanbochiphichungct_SxPhanbochiphichung");
            });

            modelBuilder.Entity<SxTiendo>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodichpk, e.Madonvi, e.Ngayphatsinh, e.Masieuthi, e.Maca });

                entity.ToTable("SxTiendo");

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

                entity.ToTable("Thamsohethong");

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

                entity.ToTable("Tinhthuongnhanvienct");

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

                entity.ToTable("Tkdoituong");

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

                entity.ToTable("TsGiaodich");

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

                entity.ToTable("TsGiaodichct");

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
                    .WithMany(p => p.TsGiaodichcts)
                    .HasForeignKey(d => new { d.Madonvi, d.Magiaodichpk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsGiaodichct_TsGiaodich");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.TsGiaodichcts)
                    .HasForeignKey(d => new { d.Madonvi, d.Mataisan })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsGiaodichct_TsTaisan");
            });

            modelBuilder.Entity<TsKhauhao>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Magiaodichpk });

                entity.ToTable("TsKhauhao");

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

                entity.ToTable("TsKhauhaoct");

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
                    .WithMany(p => p.TsKhauhaocts)
                    .HasForeignKey(d => new { d.Madonvi, d.Magiaodichpk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsKhauhaoct_TsKhauhao");

                entity.HasOne(d => d.MaNavigation)
                    .WithMany(p => p.TsKhauhaocts)
                    .HasForeignKey(d => new { d.Madonvi, d.Mataisan })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TsKhauhaoct_TsTaisan");
            });

            modelBuilder.Entity<TsLoaitaisan>(entity =>
            {
                entity.HasKey(e => new { e.Madonvi, e.Maloaitaisan })
                    .HasName("PK_TsLoaitaisan_1");

                entity.ToTable("TsLoaitaisan");

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

                entity.ToTable("TsNhomtaisan");

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

                entity.ToTable("TsTaisan");

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

                entity.ToTable("TsTaisanct");

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

                entity.ToTable("Tuyenduong");

                entity.Property(e => e.Matuyen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Sdtnguoigiansat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDTnguoigiansat");

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

                entity.Property(e => e.Tiennhap).HasColumnType("decimal(38, 8)");
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

                entity.ToTable("Vat");

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

                entity.ToTable("VtBaoduongxe");

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

                entity.ToTable("VtDinhmucthuexe");

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

                entity.ToTable("VtGiaodichthuexe");

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

                entity.ToTable("VtGiaodichthuexect");

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

                entity.ToTable("VtLichdixe");

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

                entity.ToTable("VtLoaibaoduong");

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

                entity.ToTable("VtLoaichukybaoduong");

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

                entity.ToTable("VtLoaithechap");

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

                entity.ToTable("VtThuonghieu");

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

                entity.ToTable("VtVaynganhang");

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

                entity.ToTable("VtXe");

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

                entity.ToTable("VtXetaitrohang");

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

                entity.ToTable("Vuviec");

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
                    .WithMany(p => p.Vuviecs)
                    .HasForeignKey(d => d.Madonvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vuviec_Donvi");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.Vuviecs)
                    .HasForeignKey(d => new { d.Manhomvuviec, d.Madonvi })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vuviec_Nhomvuviec");
            });

            modelBuilder.Entity<Xacnhanhoadon>(entity =>
            {
                entity.HasKey(e => new { e.Magiaodich, e.Madonvi });

                entity.ToTable("Xacnhanhoadon");

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
