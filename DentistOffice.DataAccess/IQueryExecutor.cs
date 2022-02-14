using DentistOffice.DataAccess.CQRS.Queries;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
