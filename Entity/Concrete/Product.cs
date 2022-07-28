#nullable disable

namespace Entity.Concrete
{
    public partial class Product
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int Name { get; set; }
        public int MerchantId { get; set; }
        public string Desc { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Merchant Merchant { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
