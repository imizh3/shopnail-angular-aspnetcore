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
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<Mathanggia> _logger;

        readonly ApplicationManage _manage;

        public ProductsController(ILogger<Mathanggia> logger, ApplicationManage manage)
        {
            _logger = logger;
            _manage = manage;
        }

        ///<remarks>
        /// Sample request:
        ///
        ///     GET /Products
        ///     
        ///</remarks>
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Mathanggia> Get()
        {
            return _manage.productsManage.getProducts(User);
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
