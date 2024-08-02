using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class NotificationService : INotificationService
    {
        private readonly MarketingSurplusDbContext _db;
        public NotificationService(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void AddNotification(Notification notification)
        {
            _db.Notifications.Add(notification);
            _db.SaveChanges();
        }

        public void AddNotificationCahrity(NotificationCharity notification)
        {
            _db.NotificationCharities.Add(notification);
             _db.SaveChanges();
        }

        public List<NotificationCharity> GetNotificationCharity(int charityId)
        {
            return _db.NotificationCharities
      .Where(n => n.CharityId == charityId && !n.IsRead)
      .OrderByDescending(n => n.CreatedAt)
      .ToList();
        }

        public List<Notification> GetNotifications(int userId)
        {
            return  _db.Notifications
          .Where(n => n.UserId == userId && !n.IsRead)
          .OrderByDescending(n => n.CreatedAt)
          .ToList();
        }

        public void MarkAsRead(int notificationId)
        {
            var notification =  _db.Notifications.Find(notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                _db.SaveChanges();
            }
        }

        public void MarkAsReadCharity(int notificationId)
        {
            var notification = _db.NotificationCharities.Find(notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                _db.SaveChanges();
            }
        }
    }
}
