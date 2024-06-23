using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{

        [Route("api/[controller]/[action]")]
        [ApiController]
        public class OrderController : ControllerBase
        {
            private readonly IOrder db;
            public OrderController(IOrder _db)
            {
                db = _db;
            }
            [HttpGet]
            [ActionName("GetOrders")]
            public IActionResult GetOrders()
            {
                List<Order> data = db.GetOrders();
                return Ok(data);
            }

        [HttpGet("{userId}")]
        [ActionName("GetOrdersUser")]
        public IActionResult GetOrdersUser(int userId)
        {
            List<Order> data = db.GetOrdersUser(userId);
            return Ok(data);
        }
        [HttpGet("{id}")]
            [ActionName("Get")]
            public IActionResult Get(int id)
            {
                var data = db.GetOrder(id);
                if (data != null)
                {
                    return Ok(data);
                }
                return Ok(new List<object>());// return NotFound();

            }


            [HttpPost]
            public IActionResult AddOrder([FromBody] Order order)
            {
                if (order == null)
                {
                    return Ok(new List<object>());// return BadRequest();
                }
                else
                {
                db.Save(order);
                return Ok();
            }

            }
            [HttpPut("{id}")]
            public IActionResult Put([FromBody] Order order)
            {
                if (order == null || order.Id == 0)
                {
                    return Ok(new List<object>());// return BadRequest();
                }
                else
                {
                    db.Update(order);
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
