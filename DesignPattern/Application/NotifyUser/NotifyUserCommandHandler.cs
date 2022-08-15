using DesignPattern.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Application.NotifyUser
{
    public class NotifyUserCommandHandler : IRequestHandler<NotifyUserCommand, Unit>
    {
        private readonly INotificationFactoryFacade _factoryFacade;
        public NotifyUserCommandHandler(INotificationFactoryFacade factoryFacade)
        {
            _factoryFacade = factoryFacade;
        }


        public async Task<Unit> Handle(NotifyUserCommand request, CancellationToken cancellationToken)
        {
            var notificationService = _factoryFacade.GetFacade(request.Type);

            await notificationService.SendAsync(request.Destination, request.Content);

            return Unit.Value; 
        }
    }
}
