using AutoMapper;
using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using DentistOffice.DataAccess;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DentistOffice.ApplicationServices.API.Handlers.User
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, GetUsersResponse>
    {
        private readonly IRepository<DataAccess.Entities.User> userRepository;
        private readonly IMapper mapper;

        public GetUsersHandler(IRepository<DataAccess.Entities.User> userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<GetUsersResponse> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = await this.userRepository.GetAll();
            var mappedUsers = mapper.Map<List<UserDto>>(users);
            var response = new GetUsersResponse()
            {
                Data = mappedUsers.ToList()
            };

            return response;
        }
    }
}
