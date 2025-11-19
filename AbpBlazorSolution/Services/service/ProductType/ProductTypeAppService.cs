using AbpBlazorSolution.Services.Dtos.ProductType;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.ProductType
{
    public class ProductTypeAppService : CrudAppService<Entities.ProductType, ProductTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductTypeDto> , IProductTypeAppService
    {
        public ProductTypeAppService(IRepository<Entities.ProductType, Guid> repository) : base(repository)
        {
        }
    }
}
