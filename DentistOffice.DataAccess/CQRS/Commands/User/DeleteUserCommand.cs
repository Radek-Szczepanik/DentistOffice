using System.Linq;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess.CQRS.Commands.User
{
    public class DeleteUserCommand : CommandBase<Entities.User, Entities.User>
    {
        public override async Task<Entities.User> Execute(DentistOfficeContext context)
        {
            context.Users.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
