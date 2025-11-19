using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.ProductType;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.ProductTypes
{
    public class ProductTypeAppService : CrudAppService<ProductType, ProductTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductTypeDto> , IProductTypeAppService
    {
        public ProductTypeAppService(IRepository<ProductType, Guid> repository) : base(repository)
        {
        }
    }
}
