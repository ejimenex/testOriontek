using MDEntities.Model;
using MDRepository.Abstract;
using MDService.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDService.Service
{
    public class InvoiceService : BaseService<Invoice>
    {
        public InvoiceService(IBaseRepository<Invoice> repository) : base(repository)
        {

        }
    }
}
