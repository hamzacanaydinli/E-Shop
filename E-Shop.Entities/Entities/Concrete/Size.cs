using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Size : BaseEntity
    {
        public int SizeNumber { get; set; }

        public List<ProductSize> ProductSizes { get; set; }
    }
}
