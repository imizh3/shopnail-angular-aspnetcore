using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Extensions.Configuration;
using WEB2020.Model;
using WEB2020.Models;
namespace WEB2020.Data
{
    public class BaocaoManage : BaseManage
    {
        public MARTContext db;
        public static List<Vat> Vats = new List<Vat>();
        public static List<Dmptnx> Dmptnxes = new List<Dmptnx>();
        public static List<Mathang> Mathangs = new List<Mathang>();
        public BaocaoManage(IConfiguration configuration, MARTContext _db) : base(configuration)
        {
            db = _db;
            Vats = db.Vat.Where(d => d.Madonvi == this.Madonvi).ToList();
            Dmptnxes = db.Dmptnx.Where(d => d.Madonvi == this.Madonvi).ToList();
            Mathangs = db.Mathang.Where(d => d.Madonvi == this.Madonvi).ToList();
        }
        internal List<BaoCaoXBBModel> getBaoCaoXBBTH(BaocaoRequest request)
        {
            DateTime tuNgay = DateTime.Parse(request.tuNgay);
            DateTime denNgay = DateTime.Parse(request.denNgay);
            DataTable DT_BaoCaoXBBTH = DB.BC_XUATBANBUONTH(tuNgay, denNgay, this.Madonvi, "", "", "", "", "", "", "", "", request.trangthai, "", request.manhanvien, "", 1);
            List<BaoCaoXBBModel> baoCaos = new List<BaoCaoXBBModel>();
            baoCaos = LIB.ConvertDataTableToList<BaoCaoXBBModel>(DT_BaoCaoXBBTH);
            return baoCaos;
        }
    }
}