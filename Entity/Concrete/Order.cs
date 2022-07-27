using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Order
    {
        public int Id { get; set; }
        public int ConditionId { get; set; }
        public int UserId { get; set; }
        public int FoodId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Condition Condition { get; set; }
        public virtual User User { get; set; }
    }
}
