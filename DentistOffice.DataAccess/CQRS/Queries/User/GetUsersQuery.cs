﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess.CQRS.Queries.User
{
    public class GetUsersQuery : QueryBase<List<Entities.User>>
    {
        public override Task<List<Entities.User>> Execute(DentistOfficeContext context)
        {
            return context.Users.ToListAsync();
        }
    }
}
