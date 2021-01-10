using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEB2020.Data;
using WEB2020.Model;

namespace WEB2020.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {

        private readonly ILogger<Nganhnhom> _logger;

        readonly ApplicationManage _manage;

        public CategorysController(ILogger<Nganhnhom> logger, ApplicationManage manage)
        {
            _logger = logger;
            _manage = manage;
        }
        // GET: api/Categorys
        [HttpGet]
        public IEnumerable<Nganhnhom> Get()
        {
            string Manhanvien = User.FindFirst("Manhanvien").Value;
            return _manage.categorysManage.getCategory(Manhanvien);
        }

        //// GET: api/Categorys/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Categorys
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Categorys/5
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
