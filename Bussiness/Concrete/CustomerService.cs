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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepositoryrService, IMapper mapper)
        {
            _customerRepository = customerRepositoryrService;
            _mapper = mapper;
        }

        public IDataResult<CustomerModelDto> Get(int id)
        {
            var result = _customerRepository.GetAll();
            var mapperResult = _mapper.Map<CustomerModelDto>(result);
            return new SuccessDataResult<CustomerModelDto>(mapperResult);
        }

        public IDataResult<List<CustomerModelDto>> GetAll()
        {
            var result = _customerRepository.GetAll();
            var mapperResult = _mapper.Map<List<CustomerModelDto>>(result);
            return new SuccessDataResult<List<CustomerModelDto>>(mapperResult);
        }

        public IResult Add(Customer createDto)
        {
           var customer = _mapper.Map<Customer>(createDto);
           _customerRepository.Add(customer);
              return new SuccessResult("Customer added");
        }
    }
}
