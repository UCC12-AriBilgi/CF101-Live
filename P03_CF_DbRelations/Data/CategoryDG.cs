

using Bogus;
using Microsoft.EntityFrameworkCore;
using P03_CF_DbRelations.Models;

namespace P03_CF_DbRelations.Data
{
    public class CategoryDG
    {
        // Category Fake Data Generator

        Faker<Category> fakerCategory; // Category iöçin FakeData

        public DbSet<Category> Categories; // Categories sınıfından Categories isimli bir tabloyu ifade ediyor...

        // constructor
        public CategoryDG()
        {
            fakerCategory = new Faker<Category>();

            fakerCategory.RuleFor(c => c.CategoryName, cd => cd.Commerce.Categories(1)[0]);
        }

        public void Generate(int count)
        {
            using var context=new // **** 
        }




    }
}
