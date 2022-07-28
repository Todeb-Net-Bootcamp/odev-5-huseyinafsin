#nullable disable

using System.Collections.Generic;

namespace Entity.Concrete
{
    public partial class AccountType
    {
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
