using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess.CQRS.Queries.User
{
    public class GetUserQuery : QueryBase<Entities.User>
    {
        public int Id { get; set; }

        public override async Task<Entities.User> Execute(DentistOfficeContext context)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == this.Id);
            return user;
        }
    }
}
