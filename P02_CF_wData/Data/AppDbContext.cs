using Microsoft.EntityFrameworkCore;
using P02_CF_wData.Configurations;
using P02_CF_wData.Entities;
using P02_CF_wData.Seeds;

namespace P02_CF_wData.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // inline olarak VT bağlantı cümlesini buraya tanımlayalım

            optionsBuilder.UseSqlServer("Data Source=EGITMEN;Initial Catalog=CF101Db_wData;Integrated Security=True;TrustServerCertificate=True;");
            
        }

        // DbSet lerin tanımlanması...VT tarafında oluşacaklar.

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }


        // Uygulama üzerinde bulunan modeller hazırlanma aşamasındayken daha hazırlanan Configuration,Seed classlarının dahil edilmesi

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());

            modelBuilder.ApplyConfiguration(new StudentSeed());
            modelBuilder.ApplyConfiguration(new TeacherSeed());
        }



    }
}
