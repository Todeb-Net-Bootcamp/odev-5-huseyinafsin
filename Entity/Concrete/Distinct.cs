using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Distinct
    {
        public Distinct()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
