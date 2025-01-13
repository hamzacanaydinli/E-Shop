using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int SubCategoryId { get; set; }
        public string? PhotoPath { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public SubCategory SubCategories { get; set; }
        public List<ProductSize> ProductSizes { get; set; }

    }
}
