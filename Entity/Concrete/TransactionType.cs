#nullable disable

using System.Collections.Generic;

namespace Entity.Concrete
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
