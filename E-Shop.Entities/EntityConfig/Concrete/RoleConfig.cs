using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class RoleConfig : BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.RoleName).IsRequired();
            builder.Property(p => p.RoleName).HasMaxLength(50);
            //builder.HasIndex(p => p.RoleAdi).IsUnique();

            //builder.HasData(new Role() { Id = "Ad", RoleAdi = "Admin", CreateDate = DateTime.Now });
            //builder.HasData(new Role() { Id = "us", RoleAdi = "Useer", CreateDate = DateTime.Now });

        }
    }
}
