using System.Threading.Tasks;

namespace DentistOffice.DataAccess.CQRS.Queries
{
    public abstract class QueryBase<TResult>
    {
        public abstract Task<TResult> Execute(DentistOfficeContext context);
    }
}
