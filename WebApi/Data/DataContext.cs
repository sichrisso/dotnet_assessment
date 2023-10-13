global using Microsoft.EntityFrameworkCore;
namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<Movie> Movies {get; set; }
        public DbSet<Cinema> Cinemas {get; set; }
    }
}