using System;
using System.Collections.Generic;

#nullable disable

namespace WEB2020.MartDb.Entitys
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            NsBaohiemnhanviens = new HashSet<NsBaohiemnhanvien>();
            NsChuyenbophans = new HashSet<NsChuyenbophan>();
            NsDangkylamthems = new HashSet<NsDangkylamthem>();
            NsDangkynghis = new HashSet<NsDangkynghi>();
            NsGanlichlamviecs = new HashSet<NsGanlichlamviec>();
            NsLichlamviecthangs = new HashSet<NsLichlamviecthang>();
            NsLuonghopdongnhanviens = new HashSet<NsLuonghopdongnhanvien>();
            NsPhucapnhanviens = new HashSet<NsPhucapnhanvien>();
            NsQdkhenthuongkyluats = new HashSet<NsQdkhenthuongkyluat>();
        }

        public string Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
        public string Madonvi { get; set; }
        public string Manhomkhachhang { get; set; }
        public string Dienthoai { get; set; }
        public string Dienthoai2 { get; set; }
        public string Email { get; set; }
        public DateTime? Ngaynhanviec { get; set; }
        public DateTime Ngaytao { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Tendangnhap { get; set; }
        public string Tendangnhapsua { get; set; }
        public string Cmnd { get; set; }
        public DateTime? Ngaycap { get; set; }
        public string Noicap { get; set; }
        public int? Gioitinh { get; set; }
        public int? Trangthaisudung { get; set; }
        public string Machamcong { get; set; }
        public string Maphongban { get; set; }
        public string Mabophan { get; set; }
        public string Machucvu { get; set; }
        public string Tcsonha { get; set; }
        public string Tcthonxom { get; set; }
        public string Tcxaphuong { get; set; }
        public string Tcquanhuyen { get; set; }
        public string Tctinhtp { get; set; }
        public string Htsonha { get; set; }
        public string Htthonxom { get; set; }
        public string Htxaphuong { get; set; }
        public string Htquanhuyen { get; set; }
        public string Httinhtp { get; set; }
        public string Masothue { get; set; }
        public int? Madongbo { get; set; }
        public string Manhanvienquanly { get; set; }

        public virtual NsBophan Ma { get; set; }
        public virtual NsPhongban Ma1 { get; set; }
        public virtual NsChucvu MaNavigation { get; set; }
        public virtual ICollection<NsBaohiemnhanvien> NsBaohiemnhanviens { get; set; }
        public virtual ICollection<NsChuyenbophan> NsChuyenbophans { get; set; }
        public virtual ICollection<NsDangkylamthem> NsDangkylamthems { get; set; }
        public virtual ICollection<NsDangkynghi> NsDangkynghis { get; set; }
        public virtual ICollection<NsGanlichlamviec> NsGanlichlamviecs { get; set; }
        public virtual ICollection<NsLichlamviecthang> NsLichlamviecthangs { get; set; }
        public virtual ICollection<NsLuonghopdongnhanvien> NsLuonghopdongnhanviens { get; set; }
        public virtual ICollection<NsPhucapnhanvien> NsPhucapnhanviens { get; set; }
        public virtual ICollection<NsQdkhenthuongkyluat> NsQdkhenthuongkyluats { get; set; }
    }
}
