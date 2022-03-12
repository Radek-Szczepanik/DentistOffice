using AutoMapper;
using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using DentistOffice.ApplicationServices.API.ErrorHandling;
using DentistOffice.DataAccess;
using DentistOffice.DataAccess.CQRS.Commands.User;
using DentistOffice.DataAccess.CQRS.Queries.User;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DentistOffice.ApplicationServices.API.Handlers.User
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;

        public DeleteUserHandler(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }
        public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserByIdQuery()
            {
                Id = request.UserId
            };
            var user = await this.queryExecutor.Execute(query);

            if (user == null)
            {
                return new DeleteUserResponse()
                {
                    Error = new ErrorModel(ErrorType.NotFound)
                };
            };

            var command = new DeleteUserCommand()
            {
                Parameter = user
            };

            var userFromDb = await this.commandExecutor.Execute(command);
            return new DeleteUserResponse()
            {
                Data = this.mapper.Map<UserDto>(userFromDb)
            };

        }
    }
}
