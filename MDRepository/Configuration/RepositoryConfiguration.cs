using MDEntities;
using MDEntities.Model;
using MDRepository.Abstract;
using MDRepository.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MDRepository.Configuration
{
 
        public static partial class RepositoryConfiguration
        {
        public static void AddRespositories(this IServiceCollection services)
        {
            
            services.AddScoped<IBaseRepository<Product>, ProductRepository>();
            services.AddScoped<IBaseRepository<Invoice>, InvoiceRepository>();
            services.AddScoped<IBaseRepository<InvoiceDetail>, InvoiceDetailRepository>();
        }           }
}
