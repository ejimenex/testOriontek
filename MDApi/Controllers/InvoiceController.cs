using AutoMapper;
using MDEntities.Model;
using MDRepository.Dtos;
using MDService.Service.Base;

namespace MDApi.Controllers
{
    public class InvoiceController : BaseController<Invoice, InvoiceDto, IBaseService<Invoice>>
    {
        public InvoiceController(IBaseService<Invoice> manager, IMapper Mapper) : base(manager, Mapper)
        {
        }
       
    }
}