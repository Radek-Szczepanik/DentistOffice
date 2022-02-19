using DentistOffice.DataAccess.CQRS.Commands;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly DentistOfficeContext context;

        public CommandExecutor(DentistOfficeContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TParameter, TResult>(CommandBase<TParameter, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
