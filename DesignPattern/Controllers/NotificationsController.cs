using DesignPattern.Application;
using DesignPattern.Application.NotifyUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Notify(NotifyUserCommand command)
        {
            await _mediator.Send(command);

            return Accepted();
        }
    }
}
