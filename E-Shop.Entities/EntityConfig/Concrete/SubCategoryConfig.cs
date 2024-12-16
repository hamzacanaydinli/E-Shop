using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class SubCategoryConfig : BaseConfig<SubCategory>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(100);

            builder.HasOne(p => p.Category)
                .WithMany(p => p.SubCategories)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
