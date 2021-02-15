using System.Collections.Generic;

namespace MDEntities.Model
{
    public class Invoice:BaseClass
    {
        public decimal Total { get; set; }
        public virtual List<InvoiceDetail> Detail { get; set; }
    }
}
