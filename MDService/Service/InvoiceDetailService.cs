using MDEntities.Model;
using MDRepository.Abstract;
using MDService.Service.Base;

namespace MDService.Service
{
    public class InvoiceDetailService : BaseService<InvoiceDetail>
    {
       private readonly IBaseRepository<Product> productRepository;

        public InvoiceDetailService(IBaseRepository<InvoiceDetail> repository, IBaseRepository<Product> _productRepository) : base(repository)
        {
            this.productRepository = _productRepository;
        }
        public override int Create(InvoiceDetail entity)
        { 
            var product = this.productRepository.GetOne(entity.ProductId);
            entity.Total = entity.Quantity * product.Price;
            entity.Product = null;
            entity.Invoice = null;
            return base.Create(entity);
        }
    }
    }
