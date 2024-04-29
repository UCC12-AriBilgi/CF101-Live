
using Microsoft.EntityFrameworkCore;
using P02_CF_wFakeData.Models;

namespace P02_CF_wFakeData.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }

    }
}
