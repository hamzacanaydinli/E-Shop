using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class MyUserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.SurName).HasMaxLength(50);

            builder.Property(p => p.TcNo).HasMaxLength(11);
            builder.HasIndex(p => p.TcNo).IsUnique();

            builder.Property(p => p.Email).HasMaxLength(100);
            builder.HasIndex(p => p.Email).IsUnique();

            builder.Property(p => p.Gsm).HasMaxLength(100);
            builder.HasIndex(p => p.Gsm).IsUnique();

            //builder.Property(p => p.Gender).HasMaxLength(5);

            builder.Property(p => p.Password).HasMaxLength(500);

            builder.HasOne(p => p.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.RoleId);

        }
    }
}
