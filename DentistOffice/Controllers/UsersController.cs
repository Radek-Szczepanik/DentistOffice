using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DentistOffice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator, ILogger<UsersController> logger) : base(mediator)
        {
            logger.LogInformation("We are in users controller");
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
        public Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest request, int userId)
        {
            request.userId = userId;
            
            return this.HandleRequest<UpdateUserRequest, UpdateUserResponse>(request);
        }

        [HttpDelete]
        [Route("{userId}")]
        public Task<IActionResult> DeleteUser([FromRoute] int userId)
        {
            var request = new DeleteUserRequest()
            {
                UserId = userId
            };

            return this.HandleRequest<DeleteUserRequest, DeleteUserResponse>(request);
        }
    }
}
