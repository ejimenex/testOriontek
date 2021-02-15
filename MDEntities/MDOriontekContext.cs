using MDEntities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDEntities
{
   public class MDOriontekContext: DbContext
    {
        public MDOriontekContext(DbContextOptions options)
           : base(options)
        {
                
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
