using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController: ControllerBase

    {
        private readonly ISubscription db;
        public SubscriptionController(ISubscription _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetSubscription")]
        public IActionResult GetSubscription([FromQuery] int userId, [FromQuery] int companyId)
        {
            var data = db.GetSubscription(userId, companyId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet]
        [ActionName("GetSubscriptiones")]
        public IActionResult GetSubscriptiones([FromQuery] int userId)
        {
            var data = db.GetSubscriptiones(userId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet]
        [ActionName("GetCompanySubscription")]
        public IActionResult GetCompanySubscription([FromQuery] int companyId)
        {
            var data = db.GetCompanySubscription(companyId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpPost]
        public IActionResult AddSubscription([FromBody] Subscription subscription)
        {

            if (subscription == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(subscription);
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
