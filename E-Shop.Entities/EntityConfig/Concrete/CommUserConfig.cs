using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class CommUserConfig : BaseConfig<CommUser>
    {
        public override void Configure(EntityTypeBuilder<CommUser> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(15);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Message).HasMaxLength(500);

            builder.HasData(new CommUser() { Id = 1, Name = "hamza", Email = "hamzacanaydinli@gmail.com", Message = "AAA" });
        }
    }
}

