using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product
                {

                    Id = 1,
                    Title = "Jacket",
                    Description = "Jacket",
                    Price = 400,
                    StockQuantity = 4,
                    SubCategoryId = 1,
                    PhotoPath = "/img/shopping-cart/cart-1.jpg",
                }
                );
        }
    }
}

