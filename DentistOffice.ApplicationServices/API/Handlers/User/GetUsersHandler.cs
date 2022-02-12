using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using DentistOffice.DataAccess;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DentistOffice.ApplicationServices.API.Handlers.User
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, GetUsersResponse>
    {
        private readonly IRepository<DataAccess.Entities.User> userRepository;

        public GetUsersHandler(IRepository<DataAccess.Entities.User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public Task<GetUsersResponse> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = this.userRepository.GetAll();
            var domainUsers = users.Select(u => new UserDto()
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                DateOfBirth = u.DateOfBirth
            });

            var response = new GetUsersResponse()
            {
                Data = domainUsers.ToList()
            };

            return Task.FromResult(response);
        }
    }
}
