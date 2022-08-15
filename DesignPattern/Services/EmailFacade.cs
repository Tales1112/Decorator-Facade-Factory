using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace DesignPattern.Services
{
    public class EmailFacade : INotificationFacade 
    {
        private readonly ISendGridClient _sendGridClient;
        public EmailFacade(ISendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }
        public async Task SendAsync(string destination, string content)
        {
            var from = new EmailAddress("tales.trab@gmail.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("tales.trab@gmail.com", "Example User");
            var plainTextContent = content;
            var htmlContent = $"<strong>{content}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            await _sendGridClient.SendEmailAsync(msg);
        }
    }
}
