using DentistOffice.DataAccess.CQRS.Queries;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly DentistOfficeContext context;

        public QueryExecutor(DentistOfficeContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
