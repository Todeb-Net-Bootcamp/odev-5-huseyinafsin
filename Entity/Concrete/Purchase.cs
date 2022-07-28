#nullable disable

using System.Collections.Generic;

namespace Entity.Concrete
{
    public partial class Purchase
    {
        public Purchase()
        {
            Products = new HashSet<Product>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AccountTypeId { get; set; }
        public int Quantity { get; set; }
        public string Desc { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
