using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class İletisimConfig : BaseConfig<İletisim>
    {
        public override void Configure(EntityTypeBuilder<İletisim> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Adi).HasMaxLength(50);
            builder.Property(p => p.Mail).HasMaxLength(50);
            builder.Property(p => p.Mesaj).HasMaxLength(500);
        }
    }
}
