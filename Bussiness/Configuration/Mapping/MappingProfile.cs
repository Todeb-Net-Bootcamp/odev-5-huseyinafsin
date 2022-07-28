using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dto.Concrete.Transaction;
using Entity.Concrete;

namespace Bussiness.Configuration.Mapping
{
    public class MappingProfile : Profile
    {
        //Objeleri maplamak için kullanılan bir sınıf 
        //CreateMap<Destination, Source>(); şeklinde kullanılır.

        public MappingProfile()
        {
            CreateMap<Transaction, TransactionModelDto>();
            CreateMap<TransactionCreateDto, Transaction>(); 
            
            CreateMap<Customer, CustomerModelDto>();
            CreateMap<CustomerCreateDto, Customer>();
        }
    }
}
