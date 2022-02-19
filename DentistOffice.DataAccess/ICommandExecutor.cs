using DentistOffice.DataAccess.CQRS.Commands;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParameter, TResult>(CommandBase<TParameter, TResult> command);
    }
}
