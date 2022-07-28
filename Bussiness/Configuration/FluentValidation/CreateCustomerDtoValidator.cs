using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Concrete.Transaction;
using FluentValidation;

namespace Bussiness.Configuration.FluentValidation
{
    public class CreateCustomerDtoValidator : AbstractValidator<CustomerCreateDto>
    {
        public CreateCustomerDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();

            RuleFor(x => x.IdentityNumber).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty();
        }
    }
}
