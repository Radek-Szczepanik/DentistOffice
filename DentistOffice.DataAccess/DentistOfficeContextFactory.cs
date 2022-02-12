using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DentistOffice.DataAccess
{
    public class DentistOfficeContextFactory : IDesignTimeDbContextFactory<DentistOfficeContext>
    {
        public DentistOfficeContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DentistOfficeContext>();
            optionBuilder.UseSqlServer("Data Source = .\\SQLEXPRESS; Initial Catalog = DentistOffice; Integrated Security = True");
            return new DentistOfficeContext(optionBuilder.Options);
        }
    }
}
