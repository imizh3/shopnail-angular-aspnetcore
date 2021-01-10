using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WEB2020.Model;
using Microsoft.Extensions.Logging;
using WEB2020.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;

namespace WEB2020.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<Order> _logger;

        readonly ApplicationManage _manage;

        public OrderController(ILogger<Order> logger, ApplicationManage manage)
        {
            _logger = logger;
            _manage = manage;
        }
        // POST: api/Order/Create
        [HttpPost(Name = "Create")]
        public IActionResult Create([FromBody] Order value)
        {
            var result = _manage.giaodichManage.CreateOrder(value, "ADD");
            return new JsonResult(result);
        }
        // POST: api/Order/Duyetkm
        [HttpPost(Name = "Duyetkm")]
        public IActionResult Duyetkm([FromBody] Order value)
        {
            value.Ngayphatsinh = DateTime.Now;
            var result = _manage.giaodichManage.Duyetctkhuyenmai(value);
            return new JsonResult(result);
        }
        // GET: api/order/khuyenmai
        [HttpGet(Name = "khuyenmai")]
        public IActionResult khuyenmai()
        {
            var result = _manage.giaodichManage.GetKhuyenmai();
            return new JsonResult(result);
        }
        // GET: api/order/orders
        // [HttpGet(Name = "orders")]
        // public IActionResult orders()
        // {
        //     var result=_manage.giaodichManage.GetOrders();
        //     return new JsonResult(result);
        // }

        [HttpPost(Name = "orders")]
        public IActionResult orders([FromBody] OrderRequest orderRequest)
        {
            string Manhanvien = User.FindFirst("Manhanvien").Value;
            orderRequest.maNhanVien = Manhanvien;
            var result = _manage.giaodichManage.GetOrders(orderRequest);
            return new JsonResult(result);
        }

        [HttpPost(Name = "orderDetails")]
        public IActionResult orderDetails([FromBody] OrderRequest orderRequest)
        {
            var result = _manage.giaodichManage.GetOrderDetails(orderRequest);
            if (result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost(Name = "Update")]
        public IActionResult Update([FromBody] Order order)
        {
            var result = _manage.giaodichManage.CreateOrder(order, "EDIT");
            return new JsonResult(result);
        }
        [HttpPost(Name = "Delete")]
        public IActionResult Delete([FromBody] Order order)
        {
            orderResult result = _manage.giaodichManage.DeleteOrder(order);
            return new JsonResult(result);
        }

    }
}