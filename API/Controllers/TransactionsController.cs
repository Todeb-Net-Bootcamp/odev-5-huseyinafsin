using System.Threading.Tasks;
using Bussiness.Abstract;
using Dto.Concrete.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {

        private readonly ITransactionService  _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransactionCreateDto createDto)
        {
            var result = _transactionService.Add(createDto);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpGet]
        public async Task<IActionResult> GetAll( )
        {
            var result = _transactionService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get( int id)
        {
            var result = _transactionService.Get(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
