using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Concrete.Transaction
{
    public class TransactionCreateDto
    {
        public int Amount { get; set; }
        public int Email { get; set; }
        public string Desc { get; set; }
    }
}
