#nullable disable

using System.Collections.Generic;

namespace Entity.Concrete
{
    public partial class Merchant
    {
        public Merchant()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Email { get; set; }
        public string Desc { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
