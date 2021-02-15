using MDEntities;
using MDEntities.Model;
using MDRepository.Repository.Base;

namespace MDRepository.Repository
{
    public class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(MDOriontekContext ctx) : base(ctx)
        {

        }
    }
}
