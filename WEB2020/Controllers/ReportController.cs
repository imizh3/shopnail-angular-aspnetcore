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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<Mathanggia> _logger;

        readonly ApplicationManage _manage;

        public ReportController(ILogger<Mathanggia> logger, ApplicationManage manage)
        {
            _logger = logger;
            _manage = manage;
        }
        [HttpPost(Name = "baocaoxuatbanbuonth")]
        public IActionResult baocaoxuatbanbuonth([FromBody] BaocaoRequest request)
        {
            var result = _manage.baocaoManage.getBaoCaoXBBTH(request);
            return new JsonResult(result);
        }
    }
}