using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public DateOnly OrderDate { get; set; }
        public DateOnly? RequiredDate { get; set; }
        public DateOnly? ShippedDate { get; set; }
        public decimal Freight { get; set; }


        public int AddressId { get; set; }
        public int MyUserId { get; set; }
        public int ShipperId { get; set; }


        public Address Addresses { get; set; }
        public MyUser MyUser { get; set; }
        public Shipper Shipper { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
