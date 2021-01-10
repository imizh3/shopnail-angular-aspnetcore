using System;
using System.Collections.Generic;

namespace WEB2020.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            NsBaohiemnhanvien = new HashSet<NsBaohiemnhanvien>();
            NsChuyenbophan = new HashSet<NsChuyenbophan>();
            NsDangkylamthem = new HashSet<NsDangkylamthem>();
            NsDangkynghi = new HashSet<NsDangkynghi>();
            NsGanlichlamviec = new HashSet<NsGanlichlamviec>();
            NsLichlamviecthang = new HashSet<NsLichlamviecthang>();
            NsLuonghopdongnhanvien = new HashSet<NsLuonghopdongnhanvien>();
            NsPhucapnhanvien = new HashSet<NsPhucapnhanvien>();
            NsQdkhenthuongkyluat = new HashSet<NsQdkhenthuongkyluat>();
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
        public virtual ICollection<NsBaohiemnhanvien> NsBaohiemnhanvien { get; set; }
        public virtual ICollection<NsChuyenbophan> NsChuyenbophan { get; set; }
        public virtual ICollection<NsDangkylamthem> NsDangkylamthem { get; set; }
        public virtual ICollection<NsDangkynghi> NsDangkynghi { get; set; }
        public virtual ICollection<NsGanlichlamviec> NsGanlichlamviec { get; set; }
        public virtual ICollection<NsLichlamviecthang> NsLichlamviecthang { get; set; }
        public virtual ICollection<NsLuonghopdongnhanvien> NsLuonghopdongnhanvien { get; set; }
        public virtual ICollection<NsPhucapnhanvien> NsPhucapnhanvien { get; set; }
        public virtual ICollection<NsQdkhenthuongkyluat> NsQdkhenthuongkyluat { get; set; }
    }
}
