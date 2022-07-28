using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();
        public Customer GetById(int id);
        public Customer Add(Customer customer);
        public Customer Delete(int id);
        public Customer Update(Customer customer);
    }
}
