using MDEntities;
using MDEntities.Model;
using MDRepository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MDRepository.Repository
{
    public class InvoiceDetailRepository : BaseRepository<InvoiceDetail>
    {
        public InvoiceDetailRepository(MDOriontekContext ctx) : base(ctx)
        {

        }
        public override IQueryable<InvoiceDetail> FindAll()
        {
            return base.FindAll().Include(c=> c.Product).Include(c => c.Invoice);
        }
    }
}
