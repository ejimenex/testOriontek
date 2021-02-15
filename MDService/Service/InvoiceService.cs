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
        private readonly IBaseService<InvoiceDetail> detailRepository;
        public InvoiceService(IBaseRepository<Invoice> repository, IBaseService<InvoiceDetail> _detailRepository) : base(repository)
        {
            this.detailRepository = _detailRepository;
        }
        public override int Create(Invoice entity)
        {

            var result= base.Create(entity);
            foreach (var item in entity.Detail)
            { 
                item.InvoiceId = result;
                detailRepository.Create(item);
            }
            return result;

        }
    }
}
