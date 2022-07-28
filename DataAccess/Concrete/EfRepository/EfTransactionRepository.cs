using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Contexts.DataAccess.Contexts;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class EfTransactionRepository : ITransactionRepository
    {
        private readonly BankContext _bankContext;

        public EfTransactionRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public Transaction GetById(int id)
        {
            return _bankContext.Transactions.FirstOrDefault(t => t.Id == id);
        }

        public List<Transaction> GetAll()
        {
            return _bankContext.Transactions.ToList();
        }

        public Transaction Add(Transaction transaction)
        {
             _bankContext.Transactions.Add(transaction);
             _bankContext.SaveChanges();
             return transaction;
        }

        public Transaction Delete(int id)
        {
            var transaction = _bankContext.Transactions.FirstOrDefault(x=>x.Id == id);
            _bankContext.Transactions.Remove(transaction);
            _bankContext.SaveChanges();
            return transaction;
        }

        public Transaction Update(Transaction transaction)
        {
            _bankContext.Transactions.Update(transaction);
            _bankContext.SaveChanges();
            return transaction;
        }
    }
}
