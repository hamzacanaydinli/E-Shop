using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class ProductConfig : BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Title).HasMaxLength(100);

            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(100);

            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Price).HasMaxLength(100);

            builder.Property(p => p.StockQuantity).IsRequired();
            builder.Property(p => p.StockQuantity).HasMaxLength(100);

            builder.HasOne(p => p.SubCategory).WithMany(p => p.Products).HasForeignKey(p => p.SubCategotyId);





        }
    }
}
