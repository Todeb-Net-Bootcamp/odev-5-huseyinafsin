using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Concrete.Transaction;
using FluentValidation;

namespace Bussiness.Configuration.FluentValidation
{
    public class TransactionCreateDtoValidator : AbstractValidator<TransactionCreateDto>
    {
        public TransactionCreateDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();

            RuleFor(x => x.Amount).NotEmpty();
            RuleFor(x => x.Desc).NotEmpty();
        }
    }
}
