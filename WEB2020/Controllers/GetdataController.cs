using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WEB2020.Data;
using WEB2020.Model;
using WEB2020.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WEB2020.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GetdataController : ControllerBase
    {

        readonly ApplicationManage _manage;
        readonly IWebHostEnvironment _hostEnvironment;

        public GetdataController(ApplicationManage manage, IWebHostEnvironment host)
        {
            _manage = manage;
            _hostEnvironment = host;
        }

        [HttpGet(Name = "getImages")]
        public IActionResult getImages()
        {

            var rootDir = this._hostEnvironment.WebRootPath + "/images";

            var filters = new string[] { ".jpg", ".jpeg", ".png" };

            var baseUrl = "";
            var imgUrls = Directory.EnumerateFiles(rootDir, "*.*", SearchOption.AllDirectories)
            .Where(fileName => filters.Any(filter => fileName.EndsWith(filter)))
            .Select(fileName => Path.GetRelativePath(rootDir, fileName))
            .Select(fileName => Path.Combine(baseUrl, fileName))
            .Select(fileName => fileName.Replace("\\", "/"))
            ;
            return new JsonResult(imgUrls);
        }
        [HttpGet(Name = "Dmptnx")]
        public IEnumerable<Dmptnx> dmptnx()
        {
            return _manage.getDmptnx();
        }
        [HttpGet(Name = "dmvat")]
        public IEnumerable<Vat> dmvat()
        {
            return _manage.GetVats();
        }

        [HttpGet(Name = "khachhangs")]
        public IEnumerable<Khachhang> khachhangs()
        {
            return _manage.GetKhachhangs(User);
        }

        [HttpGet(Name = "Thamsohethong")]
        public Thamso Thamsohethong()
        {
            List<Thamsohethong> lst = _manage.GetThamsohethongs();
            Thamsohethong tsChietkhaukhachhang = lst.Where(d => d.Mathamso == LIB.mtsChietKhauKhachHang).FirstOrDefault();
            return new Thamso
            {
                Checkton = _manage.Checkton,
                DataBaseXnt = _manage.DataBaseXnt,
                Madonvi = _manage.Madonvi,
                Makho = _manage.Makho,
                Maptnx = _manage.Maptnx,
                Chietkhaukhachhang = tsChietkhaukhachhang != null ? tsChietkhaukhachhang.Giatri : "",
            };
        }
        [HttpGet(Name = "capmatudong")]
        public IActionResult capmatudong()
        {
            string Matudong = LIB.GET_MATUDONG("Đơn đặt hàng web", "dathangweb", "dathangweb", _manage.Madonvi, false, "WE");
            return new JsonResult(new
            {
                Magiaodichpk = Matudong
            });
        }
    }
}