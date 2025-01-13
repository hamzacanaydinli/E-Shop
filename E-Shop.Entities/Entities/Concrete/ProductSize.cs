using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class ProductSize : BaseEntity
    {
        public Product Products { get; set; }

        public string ProductId { get; set; }
        public Size Sizes { get; set; }
        public string SizeId { get; set; }
        public int SizeNumber { get; set; }
        public int SizeAmount { get; set; }
    }
}
