using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Location
    {
        public Location()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
