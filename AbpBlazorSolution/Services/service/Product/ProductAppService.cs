using AbpBlazorSolution.Services.Dtos.Product;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Product
{
    public class ProductAppService : CrudAppService<Entities.Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto> , IProductAppService
    {
        public ProductAppService(IRepository<Entities.Product, Guid> repository) : base(repository)
        {
        }
    }
}
