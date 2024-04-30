using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_CF_wData.Entities;

namespace P02_CF_wData.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x=> x.ID); // Bu alan benim key alanım olacak
            builder.Property(x => x.ID).UseIdentityColumn(); // Bu alan otomatik olarak db tarafından artırılacak.
            builder.Property(x=> x.Name).IsRequired(); // Bu alanım gerekli bir alandır.
            builder.Property(x=> x.Name).HasMaxLength(30);// bu alanımın alacağı max değer
            builder.Property(x => x.LastName).HasMaxLength(50);

            builder.ToTable("Students"); // bu modelimin vt tarafında oluşturacağı tablo Students olsun.

        }
    }
}
