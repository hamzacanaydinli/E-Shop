using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public bool? Gender { get; set; }
        public string Password { get; set; }
        //public string RefreshToken { get; set; }
        //public DateTime? RefreshTokenEndDate { get; set; }

        public string? PhotoPath { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }


    }
}
