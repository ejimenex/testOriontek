using MDEntities.Model;
using MDService.Service;
using MDService.Service.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDService.Configuration
{
    public static partial class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Product>, ProductService>();

            services.AddScoped<IBaseService<Invoice>, InvoiceService>();
            services.AddScoped<IBaseService<InvoiceDetail>, InvoiceDetailService>();
        }
    }
}
