using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_CF_wData.Entities;

namespace P02_CF_wData.Seeds
{
    public class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(

                new Student { ID = 1, Name = "Ümit", LastName = "Karaçivi", StudentNo="1234" },
                new Student { ID = 2, Name = "Nurgül", LastName = "Karaçivi", StudentNo="5678" }

                );
        }
    }
}
