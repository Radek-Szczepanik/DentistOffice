using DentistOffice.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DentistOffice.DataAccess
{
    public class DentistOfficeContext : DbContext
    {
        public DentistOfficeContext(DbContextOptions<DentistOfficeContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserCard> UserCards { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
    }
}
