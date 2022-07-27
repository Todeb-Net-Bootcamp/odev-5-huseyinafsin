using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Concrete
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string CommentLine { get; set; }
        public int Rate { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
    }
}
