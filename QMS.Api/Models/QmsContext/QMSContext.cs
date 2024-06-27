
using Microsoft.EntityFrameworkCore;
using QMS.Api.Models.QmsContext.QmsSystem;
using QMS.Api.Models;
namespace QMS.Api.Models.QmsContext
{
    public class QMSContext : DbContext
    {
        public QMSContext(DbContextOptions<QMSContext> options)
            : base(options)
        {
        }

        public DbSet<User> UserInfo { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");

        }

    }
}
