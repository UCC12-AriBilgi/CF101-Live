using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_CF_wData.Entities;

namespace P02_CF_wData.Seeds
{
    // VT tarafında yaratılıcak tablolar için birkaç veri örneği.Teacher için
    public class TeacherSeed : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(

                new Teacher {  ID=1, Name="Teacher", LastName="One"},
                new Teacher { ID=2, Name="Teacher", LastName="Two"}

                );
        }
    }
}
