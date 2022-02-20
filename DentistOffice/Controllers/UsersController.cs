using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentistOffice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator mediator;

        public UsersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers([FromQuery] GetUsersRequest request)
        {
            var response = await this.mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetUserById([FromRoute] int userId)
        {
            var request = new GetUserByIdRequest()
            {
                UserId = userId
            };

            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] AddUserRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }



    }
}
