using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstracts
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool Status { get; set; }
    }
}
