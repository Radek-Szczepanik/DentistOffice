using DentistOffice.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DentistOffice.DataAccess
{
    public class DentistOfficeContext : DbContext
    {
        public DentistOfficeContext(DbContextOptions<DentistOfficeContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserCard> UserCards { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(a => a.UserAddress)
                .WithOne(u => u.User)
                .HasForeignKey<UserAddress>(i => i.UserId);

            builder.Entity<User>()
                .HasOne(c => c.UserContact)
                .WithOne(u => u.User)
                .HasForeignKey<UserContact>(i => i.UserId);

            builder.Entity<User>()
                .HasOne(c => c.UserCard)
                .WithOne(u => u.User)
                .HasForeignKey<UserCard>(i => i.UserId);
        }
    }
}
