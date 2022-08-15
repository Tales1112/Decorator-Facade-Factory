using DesignPattern.Application.NotifyUser;
using System.Threading.Tasks;

namespace DesignPattern.Application
{
//    public class Mediator : IMediator
//    {
//        private readonly ICommandHandler<NotifyUserCommand, Task> _notifyUserHandler;

//        public Mediator(ICommandHandler<NotifyUserCommand, Task> notifyUserHandler)
//        {
//            _notifyUserHandler = notifyUserHandler;
//        }
//        public Mediator()
//        {

//        }
//        public async Task<object> Send(ICommand command)
//        {
//            if (command is NotifyUserCommand)
//               await  _notifyUserHandler.Handle((NotifyUserCommand)command);

//            return Task.CompletedTask;
//        }
//    }
}
