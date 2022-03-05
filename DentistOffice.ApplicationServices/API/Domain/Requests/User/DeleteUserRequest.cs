using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using MediatR;

namespace DentistOffice.ApplicationServices.API.Domain.Requests.User
{
    public class DeleteUserRequest : IRequest<DeleteUserResponse>
    {
        public int UserId { get; set; }
    }
}
