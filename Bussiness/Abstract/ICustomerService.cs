using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Configuration.Results;
using Dto.Concrete.Transaction;
using Entity.Concrete;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        public IDataResult<CustomerModelDto> Get(int id);
        public IDataResult<List<CustomerModelDto>> GetAll();
        public IResult Add(Customer createDto);
   }
}
