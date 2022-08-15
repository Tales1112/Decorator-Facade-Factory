using System.Threading.Tasks;
using SendGrid;
using Serilog;

namespace DesignPattern.Services
{
    public class SmsFacade : INotificationFacade
    {
        private readonly ISendGridClient _sendGridClient;
        public SmsFacade(ISendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }
        public Task SendAsync(string destination, string content)
        {
            Log.Information($"SMS was sent to {destination} with content: {content}");

            return Task.CompletedTask;
        }
    }
}
