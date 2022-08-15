using DesignPattern.Models;

namespace DesignPattern.Services
{
    public interface INotificationFactoryFacade
    {
        INotificationFacade GetFacade(NotificationType notificationFacade);
    }
}
