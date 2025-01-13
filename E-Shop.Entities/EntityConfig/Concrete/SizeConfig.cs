using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class SizeConfig : BaseConfig<Size>
    {
        public override void Configure(EntityTypeBuilder<Size> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SizeNumber).HasMaxLength(20).IsRequired();

            builder.HasData(new Size() { Id = 1, SizeNumber = 30, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { Id = 2, SizeNumber = 32, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { Id = 3, SizeNumber = 34, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { Id = 4, SizeNumber = 36, CreatedAt = DateTime.Now });


        }
    }
}
