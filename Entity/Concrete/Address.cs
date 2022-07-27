using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Address
    {
        public Address()
        {
            Restaurants = new HashSet<Restaurant>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int LocationId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string AddressLine { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual City City { get; set; }
        public virtual Distinct District { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
