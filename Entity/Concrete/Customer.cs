#nullable disable

using System.Collections.Generic;

namespace Entity.Concrete
{
    public partial class Customer
    {
        public Customer()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public int CustomerTypeId { get; set; }
        public string IdentityNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
