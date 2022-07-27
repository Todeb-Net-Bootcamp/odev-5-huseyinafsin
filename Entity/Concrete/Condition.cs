using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Condition
    {
        public Condition()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
