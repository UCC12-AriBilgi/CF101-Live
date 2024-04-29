using Microsoft.EntityFrameworkCore;
using P01_CF.Entities;

namespace P01_CF.Data
{
    public class StudentDbContext : DbContext
    {
        // DbContext VT yapımı içinde barındıran sınıf 

        public StudentDbContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // tüm context ile ilgili olarak gerekiyorsa gerekli konfigüre işlemleri için yazılacak olan kodların bulunduğu bölüm

            // Database Connection string konfigürasyonu gibi

            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // burası modellerimiz yaratılırken eğer yapılacak işlemler varsa bu bölüme yazılır..
        }

        // Db tarafında yer alacak olan tablolarımızın model tanımlarını tanımlıyoruz...DbSet <--> table(db tarafında)

        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Standard> Standards { get; set; }


    }
}
