using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Bussiness.Abstract;
using Bussiness.Concrete;
using Bussiness.Configuration.Filters;
using Bussiness.Configuration.FluentValidation;
using Bussiness.Configuration.Mapping;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Contexts.DataAccess.Contexts;

namespace TodebBitirmeProjesi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers(options =>
            {
                options.Filters.Add(new ValidateFilterAttribute());

            }).AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssemblyContaining<CreateCustomerDtoValidator>();
                x.RegisterValidatorsFromAssemblyContaining<TransactionCreateDtoValidator>();
              
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;

            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TodebBitirmeProjesi", Version = "v1" });
            });
            services.AddDbContext<BankContext>();
            services.AddScoped<ICustomerRepository, EfCustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ITransactionRepository, EfTransactionRepository>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddAutoMapper(config =>
            {
                config.AddProfile(new MappingProfile());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodebBitirmeProjesi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
