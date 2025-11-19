using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.ProductUnit
{
    public interface IProductUnitAppService : ICrudAppService<ProductUnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductUnitDto>
    {
    }
}
