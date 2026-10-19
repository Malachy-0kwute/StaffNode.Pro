using Microsoft.EntityFrameworkCore;
using StaffNode.Pro.Domain;
using StaffNode.Pro.Domain.Common;

namespace StaffNode.Pro.Persistence.DatabaseContext
{
    public class StaffNodeProDatabaseContext : DbContext
    {
        public virtual DbSet<ContactDataModel> Contacts => Set<ContactDataModel>();
        public virtual DbSet<EmployeeDataModel> Employees => Set<EmployeeDataModel>();
        public virtual DbSet<ProfileDataModel> Profiles => Set<ProfileDataModel>();

        public StaffNodeProDatabaseContext(DbContextOptions<StaffNodeProDatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactDataModel>();
            modelBuilder.Entity<EmployeeDataModel>();
            modelBuilder.Entity<ProfileDataModel>();
        }
    }
}
