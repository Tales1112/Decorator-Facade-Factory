using DesignPattern.Models;
using MediatR;

namespace DesignPattern.Application.NotifyUser
{
    public class NotifyUserCommand : IRequest   
    {
        public string Destination { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
    }
}
