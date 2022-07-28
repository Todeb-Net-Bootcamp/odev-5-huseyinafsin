#nullable disable

namespace Entity.Concrete
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int PurchaseId { get; set; }
        public int TransactionTypeId { get; set; }
        public int Amount { get; set; }
        public int Email { get; set; }
        public string Desc { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
