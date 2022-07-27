using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
            Distincts = new HashSet<Distinct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Distinct> Distincts { get; set; }
    }
}
