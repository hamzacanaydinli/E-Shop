using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class CategoryConfig : BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CategoryName).IsRequired();
            builder.Property(p => p.CategoryName).HasMaxLength(100);


            builder.Property(p => p.Description).HasMaxLength(100);




        }
    }
}
