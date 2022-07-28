using System.Threading.Tasks;
using AutoMapper;
using Bussiness.Abstract;
using Dto.Concrete.Transaction;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomersController(IMapper mapper, ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerCreateDto createDto)
        {
            var customer = _mapper.Map<Customer>(createDto);
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = _customerService.Get(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
