using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category
                {
                    Id = 1,
                    CategoryName = "T-Shirt",
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Jacket"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Mont"
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Shoes"
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Bags"
                }
            );
        }
    }
}