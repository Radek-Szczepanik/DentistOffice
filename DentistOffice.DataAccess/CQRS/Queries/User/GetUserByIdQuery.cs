using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess.CQRS.Queries.User
{
    public class GetUserByIdQuery : QueryBase<Entities.User>
    {
        public int Id { get; set; }

        public override async Task<Entities.User> Execute(DentistOfficeContext context)
        {
            var user = await context.Users
                .Include(x => x.UserAddress)
                .Include(x => x.UserContact)
                .Include(x => x.UserCard)
                .FirstOrDefaultAsync(x => x.Id == this.Id);
                
            return user;
            
        }
    }
}
