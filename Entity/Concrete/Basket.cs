using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Basket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual User User { get; set; }
    }
}
