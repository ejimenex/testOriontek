using AutoMapper;
using MDEntities.Model;
using MDRepository.Dtos;
using MDService.Service.Base;

namespace MDApi.Controllers
{
    public class ProductController : BaseController<Product, ProductDto, IBaseService<Product>>
    {
        public ProductController(IBaseService<Product> manager, IMapper Mapper) : base(manager, Mapper)
        {
        }
       
    }
}