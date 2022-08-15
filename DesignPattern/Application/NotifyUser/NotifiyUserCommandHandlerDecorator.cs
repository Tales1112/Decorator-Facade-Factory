using MediatR.Pipeline;
using Newtonsoft.Json;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Application.NotifyUser
{
    public class NotifiyUserCommandHandlerDecorator : IRequestPreProcessor<NotifyUserCommand>
    {
        public Task Process(NotifyUserCommand request, CancellationToken cancellationToken)
        {
            Log.Information($"Command {request.GetType().Name} was handle with data {JsonConvert.SerializeObject(request)}");

            return Task.CompletedTask;
        }
    }
}
