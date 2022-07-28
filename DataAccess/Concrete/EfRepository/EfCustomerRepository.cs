using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Contexts.DataAccess.Contexts;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class EfCustomerRepository : ICustomerRepository
    {
        private readonly BankContext _bankContext;

        public EfCustomerRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public Customer GetById(int id)
        {
            return _bankContext.Customers.FirstOrDefault(t => t.Id == id);
        }

        public List<Customer> GetAll()
        {
            return _bankContext.Customers.ToList();
        }

        public Customer Add(Customer customer)
        {
            _bankContext.Customers.Add(customer);
            _bankContext.SaveChanges();
            return customer;
        }

        public Customer Delete(int id)
        {
            var customer = _bankContext.Customers.FirstOrDefault(x => x.Id == id);
            _bankContext.Customers.Remove(customer);
            _bankContext.SaveChanges();
            return customer;
        }

        public Customer Update(Customer customer)
        {
            _bankContext.Customers.Update(customer);
            _bankContext.SaveChanges();
            return customer;
        }
    }
}
