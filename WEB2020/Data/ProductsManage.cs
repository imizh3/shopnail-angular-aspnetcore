using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WEB2020.Model;

namespace WEB2020.Data
{
    public class ProductsManage : BaseManage
    {
        private readonly CategorysManage categorysManage;
        public ProductsManage(IConfiguration configuration) : base(configuration)
        {
            categorysManage = new CategorysManage(configuration);
        }

        internal IEnumerable<Mathanggia> getProducts(System.Security.Claims.ClaimsPrincipal user)
        {
            string Manhanvien = user.FindFirst("Manhanvien").Value;
            IEnumerable<Nganhnhom> nganhnhoms = categorysManage.getCategory(Manhanvien);
            DataTable dataMathang = DB.Getdata_VTHH_MATHANG(DB.XNT_TABLENAME(DateTime.Parse("08/01/2021")), this.Madonvi, this.DataBaseXnt, 1);
            dataMathang = (from mh in dataMathang.AsEnumerable()
                           join pq in nganhnhoms on mh["Manhomhang"] equals pq.Ma
                           select (mh)
            ).CopyToDataTable();


            List<Mathanggia> listMathhang = LIB.ConvertDataTable<Mathanggia>(dataMathang).ToList();
            return listMathhang.AsEnumerable<Mathanggia>();
        }
    }
}
