using AutoMapper;
using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using DentistOffice.DataAccess;
using DentistOffice.DataAccess.CQRS.Queries.User;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DentistOffice.ApplicationServices.API.Handlers.User
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;

        public GetUserByIdHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<GetUserByIdResponse> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserByIdQuery()
            {
                Id = request.UserId
            };

            var user = await this.queryExecutor.Execute(query);
            var mappedUser = this.mapper.Map<UserDto>(user);
            return new GetUserByIdResponse()
            {
                Data = mappedUser
            };
        }
    }
}
