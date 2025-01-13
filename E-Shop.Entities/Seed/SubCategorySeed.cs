using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class SubCategorySeed : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(

                new SubCategory
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Jacket"
                },
                new SubCategory
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Shoes"
                },
                new SubCategory
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Mont"
                }
               );
        }
    }
}