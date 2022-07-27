using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class User
    {
        public User()
        {
            Baskets = new HashSet<Basket>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Mail { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
