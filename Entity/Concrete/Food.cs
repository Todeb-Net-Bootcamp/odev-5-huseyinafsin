using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Food
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Desc { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Content Content { get; set; }
    }
}
