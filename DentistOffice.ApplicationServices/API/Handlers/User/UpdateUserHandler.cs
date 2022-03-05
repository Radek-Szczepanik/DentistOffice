﻿using AutoMapper;
using DentistOffice.ApplicationServices.API.Domain.Models;
using DentistOffice.ApplicationServices.API.Domain.Requests.User;
using DentistOffice.ApplicationServices.API.Domain.Responses.User;
using DentistOffice.DataAccess;
using DentistOffice.DataAccess.CQRS.Commands.User;
using DentistOffice.DataAccess.CQRS.Queries.User;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DentistOffice.ApplicationServices.API.Handlers.User
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        private readonly ICommandExecutor commandExecutor;

        public UpdateUserHandler(IMapper mapper, IQueryExecutor queryExecutor,  ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
            this.commandExecutor = commandExecutor;
        }

        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            //var query = new GetUserByIdQuery()
            //{
            //    Id = request.userId
            //};
            //var user = await this.queryExecutor.Execute(query);

            //if (user == null)
            //{
            //    return null;
            //};
            //var command = new UpdateUserCommand()
            //{
            //    Parameter = user
            //};
            //var userFromDb = await this.commandExecutor.Execute(command);

            //return new UpdateUserResponse()
            //{
            //    Data = this.mapper.Map<UserDto>(userFromDb)
            //};

            var user = this.mapper.Map<DataAccess.Entities.User>(request);
            var command = new UpdateUserCommand()
            {
                Parameter = user
            };

            var updatedUser = await this.commandExecutor.Execute(command);

            return new UpdateUserResponse()
            {
                Data = this.mapper.Map<UserDto>(updatedUser) 
            };

        }
    }
}
