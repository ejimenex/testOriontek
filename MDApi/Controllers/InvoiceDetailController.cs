using AutoMapper;
using MDEntities.Model;
using MDRepository.Dtos;
using MDService.Service.Base;

namespace MDApi.Controllers
{
    public class InvoiceDetailController : BaseController<InvoiceDetail, InvoiceDetailDto, IBaseService<InvoiceDetail>>
    {
        public InvoiceDetailController(IBaseService<InvoiceDetail> manager, IMapper Mapper) : base(manager, Mapper)
        {
        }
       
    }
}