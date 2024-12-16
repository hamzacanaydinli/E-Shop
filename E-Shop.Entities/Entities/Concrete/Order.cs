using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime RequiredDate { get; set; } = DateTime.Now.AddDays(2);
        public DateTime ShippedDate { get; set; } = DateTime.Now.AddDays(3);
        public string ShipVia { get; set; }
        public string ShipAdress { get; set; }
        public string ShipCity { get; set; }

        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
