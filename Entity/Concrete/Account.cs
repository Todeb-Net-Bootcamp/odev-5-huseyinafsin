#nullable disable

using System;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AccountTypeId { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
