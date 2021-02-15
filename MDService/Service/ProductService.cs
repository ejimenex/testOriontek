using MDEntities.Model;
using MDRepository.Abstract;
using MDService.Service.Base;

namespace MDService.Service
{
    public class ProductService:BaseService<Product>
    {
        public ProductService(IBaseRepository<Product> repository) : base(repository)
        {

        }
    }
}
