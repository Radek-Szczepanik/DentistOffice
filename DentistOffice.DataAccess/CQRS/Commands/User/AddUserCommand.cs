using DentistOffice.DataAccess;
using DentistOffice.DataAccess.CQRS.Commands;
using System.Threading.Tasks;

namespace DentistOffice.ApplicationServices.API.Domain.Responses.User
{
    public class AddUserCommand : CommandBase<DataAccess.Entities.User, DataAccess.Entities.User>
    {
        public override async Task<DataAccess.Entities.User> Execute(DentistOfficeContext context)
        {
            await context.Users.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
