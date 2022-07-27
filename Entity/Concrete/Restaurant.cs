using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
