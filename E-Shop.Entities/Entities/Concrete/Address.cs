using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{

    public class Address : BaseEntity
    {
        public string AddressName { get; set; } //Office, Home etc.
        public string AddressDescription { get; set; } //Street,Neigboorhood,Apartment etc.
        public string District { get; set; } //Kadıköy, Beşiktaş etc.
        public string Province { get; set; } //İstanbul,Balıkesir etc.

        public int MyUserId { get; set; } //foreignkey
        //navigation property
        public MyUser MyUser { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}