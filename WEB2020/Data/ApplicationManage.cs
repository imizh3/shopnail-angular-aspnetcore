using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WEB2020.Models;

namespace WEB2020.Data
{
    public class ApplicationManage : BaseManage
    {
        public ProductsManage productsManage;
        public CategorysManage categorysManage;
        public GiaodichManage giaodichManage;
        public BaocaoManage baocaoManage;
        public MARTContext db;
        public ApplicationManage(IConfiguration configuration, MARTContext _db) : base(configuration)
        {
            productsManage = new ProductsManage(configuration);
            categorysManage = new CategorysManage(configuration);
            giaodichManage = new GiaodichManage(configuration, _db);
            baocaoManage = new BaocaoManage(configuration, _db);
            db = _db;
            Ngayphatsinh ngayphatsinh = db.Ngayphatsinh.Where(d => d.Madonvi == this.Madonvi && d.Trangthai == 1).FirstOrDefault();
            PublicValue.ngayPhatSinh = ngayphatsinh != null ? ngayphatsinh.Ngayphatsinh1 : DateTime.Now;
        }

        public List<Dmptnx> getDmptnx()
        {
            return db.Dmptnx.Where(db => db.Madonvi == this.Madonvi).ToList();
        }

        public List<Vat> GetVats()
        {
            return db.Vat.Where(d => d.Madonvi == this.Madonvi).ToList();
        }

        public List<Khachhang> GetKhachhangs(System.Security.Claims.ClaimsPrincipal user)
        {
            string Manhanvien = user.FindFirst("Manhanvien").Value;
            string Madonvi = user.FindFirst("Madonvi").Value;
            List<Nhanvienkhachhang> nhanvienkhachhangs = db.Nhanvienkhachhang.Where(d => d.Madonvi == Madonvi && d.Manhanvien == Manhanvien).ToList();
            List<Khachhang> dsKhachhang = db.Khachhang.Where(d => d.Madonvi == this.Madonvi && d.Trangthai == 1 && d.Maloaikhach == "KH" || d.Maloaikhach == "KHNCC").ToList();
            dsKhachhang = (from kh in dsKhachhang
                           join nvkh in nhanvienkhachhangs on kh.Makhachhang equals nvkh.Makhachhang
                           select (kh)
                    ).ToList();
            return dsKhachhang;
        }

        public List<Thamsohethong> GetThamsohethongs()
        {
            return db.Thamsohethong.Where(db => db.Madonvi == this.Madonvi).ToList();
        }

        public decimal Gettonkho(string Masanpham)
        {
            try
            {
                DataTable dtton = DB.XNT_GETTONKHO(this.DataBaseXnt, DB.XNT_TABLENAME(DateTime.Now), this.Makho, this.Madonvi, Masanpham);
                if (dtton != null && dtton.Rows.Count > 0)
                {
                    decimal soton = 0;
                    decimal.TryParse(dtton.Rows[0]["Toncuoikysl"].ToString(), out soton);
                    return Math.Round(soton, 0);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
