using Microsoft.EntityFrameworkCore;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.Infra.ContextoBd
{
    public class BdContext : DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {}
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e => {  
                e.HasKey(de => de.Id);
                e.ToTable("Users");
            });

        }
    }
}
