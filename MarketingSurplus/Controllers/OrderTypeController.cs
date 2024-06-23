using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderTypeController: ControllerBase
    {
        private readonly IOrderType db;
        public OrderTypeController(IOrderType _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetOrderTypes()
        {
            var data = db.GetOrderTypes();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetOrderType(id);
            if (data != null)
            {
                return Ok(data);
            }
            // return NotFound();
            return Ok(new List<object>());
        }
        [HttpPost]
        public IActionResult AddOrderType([FromBody] OrderType orderType)
        {
            if (orderType == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(orderType);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] OrderType orderType)
        {
            if (orderType == null || orderType.Id == 0)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(orderType);
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return Ok();
        }
    }
}
