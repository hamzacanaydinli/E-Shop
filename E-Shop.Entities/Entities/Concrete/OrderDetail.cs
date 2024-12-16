using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public int OrderId { get; set; }
        public Order Orders { get; set; }

        public int ProductId { get; set; }
        public Product Products { get; set; }

    }
}
