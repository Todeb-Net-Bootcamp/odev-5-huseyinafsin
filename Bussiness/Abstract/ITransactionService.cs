using System.Collections.Generic;
using Bussiness.Configuration.Results;
using Dto.Concrete.Transaction;

namespace Bussiness.Abstract
{
    public interface ITransactionService
    {
        public IDataResult<TransactionModelDto> Get(int id);
        public IDataResult<List<TransactionModelDto>> GetAll();
        public IResult Add(TransactionCreateDto createDto);
    }
}