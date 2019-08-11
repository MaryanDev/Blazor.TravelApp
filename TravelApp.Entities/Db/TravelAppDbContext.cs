using Microsoft.EntityFrameworkCore;

namespace TravelApp.Entities.Db
{
    public class TravelAppDbContext : DbContext
    {
        public TravelAppDbContext() : base()
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DBModelBuilder.OnModelBuilder(modelBuilder);
        }

        DbSet<Role> Roles { get; set; }
        DbSet<User> Users { get; set; }
    }
}
