using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ITransactionRepository
    {
        public Transaction GetById(int id);
        public List<Transaction> GetAll();
        public Transaction Add(Transaction transaction);
        public Transaction Delete(int id);
        public Transaction Update(Transaction transaction);
    }
}
