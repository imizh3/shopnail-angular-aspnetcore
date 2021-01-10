using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WEB2020.Model;

namespace WEB2020.Data
{
    public class CategorysManage : BaseManage
    {
        public CategorysManage(IConfiguration configuration) : base(configuration)
        {
        }

        internal IEnumerable<Nganhnhom> getCategory(string Manhanvien)
        {
            try
            {
                //  DT_GIAODICH = (from GD in DT_GIAODICH.AsEnumerable()
                //                            join KH in SessionStart.DmKhachhangALL.AsEnumerable() on GD["customerCode"] equals KH[KhachhangFields.MakhachhangColumn.ColumnName]
                //                            into KHGD
                //                            from KH in KHGD.DefaultIfEmpty()
                //                            join NV in SessionStart.DmNhanvien.AsEnumerable() on GD["userCode"] equals NV[nhanvienFields.ManhanvienColumn.ColumnName]
                //                            into NVGD
                //                            from NV in NVGD.DefaultIfEmpty()
                //                            select addkhachhang(GD, KH, NV)).CopyToDataTable();
                DataTable nganhnhoms = DB.WEB_GETNGANHNHOM(this.Madonvi);
                DataTable phanquyennganhnhom = DB.GetData_VTHH_DSphanquyennvhh();
                nganhnhoms = (from nganhnhom in nganhnhoms.AsEnumerable()
                              join phanquyen in phanquyennganhnhom.AsEnumerable() on nganhnhom["Ma"] equals phanquyen["Manganh"]
                              where phanquyen["Manhanvien"].ToString() == Manhanvien
                              select (nganhnhom)
                            ).Concat(from nganhnhom in nganhnhoms.AsEnumerable()
                                     join phanquyen in phanquyennganhnhom.AsEnumerable() on nganhnhom["Macha"] equals phanquyen["Manganh"]
                                     where phanquyen["Manhanvien"].ToString() == Manhanvien
                                     select (nganhnhom)).CopyToDataTable();
                List<Nganhnhom> c = LIB.ConvertDataTable<Nganhnhom>(nganhnhoms).ToList();

                return c;
            }
            catch
            {
                return new List<Nganhnhom>();
            }
        }

        private IEnumerable<Categorys> createCategory(List<Nganhnhom> nganhnhoms)
        {
            List<Categorys> c = new List<Categorys>();
            List<Categorys> lNhomcha = nganhnhoms.Where(d => d.Macha == null || string.IsNullOrEmpty(d.Macha)).Select(d => new Categorys { title = d.Ten, link = "/Home/" + d.Ma, children = nganhnhoms.Where(c => c.Macha == d.Ma).Select(c => new Categorys { title = c.Ten, link = "/Home/" + d.Ma + "/" + c.Ma }).ToList() }).ToList();
            return lNhomcha;
        }
    }
}
