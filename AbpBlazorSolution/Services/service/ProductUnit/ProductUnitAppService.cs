using AbpBlazorSolution.Services.Dtos.ProductUnit;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.ProductUnit
{
    public class ProductUnitAppService : CrudAppService<Entities.ProductUnit, ProductUnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductUnitDto> ,IProductUnitAppService
    {
        public ProductUnitAppService(IRepository<Entities.ProductUnit, Guid> repository) : base(repository)
        {
        }
    }
}
