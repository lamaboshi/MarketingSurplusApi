using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface INotificationService
    {
        public void AddNotification(Notification  notification);
        public void AddNotificationCahrity(NotificationCharity notification);
        public List<Notification> GetNotifications(int userId);
        public List<NotificationCharity> GetNotificationCharity(int charityId);
        public void MarkAsRead(int notificationId);
        public void MarkAsReadCharity(int notificationId);
    }
}
