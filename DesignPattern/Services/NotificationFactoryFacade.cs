using DesignPattern.Models;
using SendGrid;

namespace DesignPattern.Services
{
    public class NotificationFactoryFacade : INotificationFactoryFacade
    {
        private readonly ISendGridClient _sendGridClient;
        public NotificationFactoryFacade(ISendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }
        public INotificationFacade GetFacade(NotificationType notificationFacade)
        {
            if (notificationFacade == NotificationType.Email)
                return new EmailFacade(_sendGridClient);
            else
                return new SmsFacade(_sendGridClient);
        }
    }
}
