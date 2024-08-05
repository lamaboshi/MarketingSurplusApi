using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotificationsController: ControllerBase
    {
        private readonly INotificationService db;
        public NotificationsController(INotificationService _db)
        {
            db = _db;
        }
        [HttpGet("{userId}")]
        [ActionName("GetNotifications")]
        public IActionResult GetNotifications(int userId)
        {
            var data = db.GetNotifications(userId);
            return Ok(data);
        }
        [HttpGet("{companyId}")]
        [ActionName("GetNotificationCompanyForUser")]
        public IActionResult GetNotificationCompanyForUser(int companyId)
        {
            var data = db.GetNotificationCompanyForUser(companyId);
            return Ok(data);
        }
        [HttpGet("{companyId}")]
        [ActionName("GetNotificationCompanyForCharity")]
        public IActionResult GetNotificationCompanyForCharity(int companyId)
        {
            var data = db.GetNotificationCompanyForCharity(companyId);
            return Ok(data);
        }

        [HttpGet("{charityId}")]
        [ActionName("GetNotificationCharity")]
        public IActionResult GetNotificationCharity(int charityId)
        {
            var data = db.GetNotificationCharity(charityId);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddNotification([FromBody] Notification notification)
        {
            if (notification == null)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
                db.AddNotification(notification);
                return Ok();

            }

        }
        [HttpPost]
        public IActionResult AddNotificationCahrity([FromBody] NotificationCharity notification)
        {
            if (notification == null)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
                db.AddNotificationCahrity(notification);
                return Ok();

            }

        }
        [HttpPost("{notificationId}")]
        public IActionResult MarkAsRead( int notificationId)
        {
            db.MarkAsRead(notificationId);
            return Ok();

        }
        [HttpPost("{notificationId}")]
        public IActionResult MarkAsReadCharity(int notificationId)
        {
            db.MarkAsReadCharity(notificationId);
            return Ok();

        }
    }
}
