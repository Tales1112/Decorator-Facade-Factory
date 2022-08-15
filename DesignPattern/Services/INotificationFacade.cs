using System.Threading.Tasks;

namespace DesignPattern.Services
{
    public interface INotificationFacade
    {
        Task SendAsync(string destination, string content);
    }
}
