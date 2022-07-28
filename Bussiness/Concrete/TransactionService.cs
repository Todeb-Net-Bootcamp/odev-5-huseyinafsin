using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bussiness.Abstract;
using Bussiness.Configuration.Results;
using DataAccess.Abstract;
using Dto.Concrete.Transaction;
using Entity.Concrete;

namespace Bussiness.Concrete
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public IDataResult<TransactionModelDto> Get(int id)
        {
            var result = _transactionRepository.GetById(id);
            var mapperResult = _mapper.Map<TransactionModelDto>(result);
            return new SuccessDataResult<TransactionModelDto>(mapperResult);
        }

        public IDataResult<List<TransactionModelDto>> GetAll()
        {
            var result = _transactionRepository.GetAll();
            var mapperResult = _mapper.Map<List<TransactionModelDto>>(result);
            return new SuccessDataResult<List<TransactionModelDto>>(mapperResult);
        }

        public IResult Add(TransactionCreateDto createDto)
        {
            var transaction = _mapper.Map<Transaction>(createDto);
             _transactionRepository.Add(transaction);
            return new SuccessResult("Transaction added successfully");
        }
    }
}