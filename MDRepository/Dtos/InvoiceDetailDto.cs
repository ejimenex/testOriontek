using System;
using System.Collections.Generic;
using System.Text;

namespace MDRepository.Dtos
{
   public class InvoiceDetailDto:BaseDto
    {
        public int Quantity { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Total { get; set; }
        public string ProductName { get; set; }
        
    }
}
