using MDEntities;
using MDEntities.Model;
using MDRepository.Repository.Base;

namespace MDRepository.Repository
{
    public class ProductRepository: BaseRepository<Product>
    {
        public ProductRepository(MDOriontekContext ctx) : base(ctx)
        {

        }
    }
}
