using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_CF_wData.Entities;

namespace P02_CF_wData.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x=> x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(30);
            //builder.Property(x=> x.Name).IsRequired().HasMaxLength(30); 13-14 ün birleşik hali
            builder.Property(x=> x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50);

            builder.ToTable("Teachers"); // db tarafındaki tablo
        }
    }
}
