using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.ProductUnit;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.ProductUnits
{
    public class ProductUnitAppService : CrudAppService<ProductUnit, ProductUnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductUnitDto> ,IProductUnitAppService
    {
        public ProductUnitAppService(IRepository<ProductUnit, Guid> repository) : base(repository)
        {
        }
    }
}
