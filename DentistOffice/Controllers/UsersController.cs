using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentistOffice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpGet]
        public Task<IActionResult> GetAllUsers([FromQuery] GetUsersRequest request)
        {
            return this.HandleRequest<GetUsersRequest, GetUsersResponse>(request);
        }

        [HttpGet]
        [Route("{userId}")]
        public Task<IActionResult> GetUserById([FromRoute] int userId)
        {
            var request = new GetUserByIdRequest()
            {
                UserId = userId
            };

            return this.HandleRequest<GetUserByIdRequest, GetUserByIdResponse>(request);
        }

        [HttpPost]
        public Task<IActionResult> AddUser([FromBody] AddUserRequest request)
        {
            return this.HandleRequest<AddUserRequest, AddUserResponse>(request);
        }

        [HttpPut]
        [Route("{userId}")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest request, int userId)
        {
            request.userId = userId;
            var response = await this.mediator.Send(request);
            return this.Ok();
        }

        [HttpDelete]
        [Route("{userId}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int userId)
        {
            var request = new DeleteUserRequest()
            {
                UserId = userId
            };

            var response = await this.mediator.Send(request);
            return this.NoContent();
        }
    }
}
