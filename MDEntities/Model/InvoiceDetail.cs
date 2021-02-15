using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MDEntities.Model
{
   public class InvoiceDetail:BaseClass
    {
        public int Quantity { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Total { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }
    }
}
