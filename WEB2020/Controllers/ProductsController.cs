using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEB2020.Data;
using WEB2020.Model;

namespace WEB2020.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<Mathanggia> _logger;

        readonly ApplicationManage _manage;
        readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(ILogger<Mathanggia> logger, ApplicationManage manage, IWebHostEnvironment host)
        {
            _logger = logger;
            _manage = manage;
            _hostEnvironment = host;
        }

        ///<remarks>
        /// Sample request:
        ///
        ///     GET /Products
        ///     
        ///</remarks>
         // GET: api/Products/getProducts
        [HttpGet]
        public IEnumerable<Mathanggia> getProducts()
        {
            return _manage.productsManage.getProducts(User);
        }

        //POST: api/Products/UploadImage
        [HttpPost(Name = "UploadImage"), DisableRequestSizeLimit]
        public IActionResult UploadImage()
        {
            try
            {
                var file = Request.Form.Files["file"];
                var masieuthi = Request.Form["masieuthi"];
                var imgName = masieuthi + Path.GetExtension(file.FileName);
                if (file.Length > 0)
                {
                    string path = _hostEnvironment.WebRootPath + "/images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + imgName))
                    {
                        file.CopyTo(fileStream);
                        fileStream.Flush();
                        return Ok();
                    }
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
        //// GET: api/Products/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
