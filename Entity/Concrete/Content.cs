using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Content
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Food IdNavigation { get; set; }
    }
}
