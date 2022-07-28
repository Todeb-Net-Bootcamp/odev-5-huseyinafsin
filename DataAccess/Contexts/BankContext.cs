using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    using Entity.Concrete;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    namespace DataAccess.Contexts
    {
        public class BankContext : DbContext
        {
            private IConfiguration _configuration;

            public BankContext(IConfiguration configuration)
            {
                _configuration = configuration;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnectionString");
                base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
            }

  

            public virtual DbSet<Account> Accounts { get; set; }
            public virtual DbSet<AccountType> AccountTypes { get; set; }
            public virtual DbSet<Customer> Customers { get; set; }
            public virtual DbSet<CustomerType> CustomerTypes { get; set; }
            public virtual DbSet<Merchant> Merchants { get; set; }
            public virtual DbSet<Product> Products { get; set; }
            public virtual DbSet<Purchase> Purchases { get; set; }
            public virtual DbSet<Transaction> Transactions { get; set; }
            public virtual DbSet<TransactionType> TransactionTypes { get; set; }


        }
    }
}
