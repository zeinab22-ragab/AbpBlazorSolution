using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.ProductType
{
    public interface IProductTypeAppService : ICrudAppService<ProductTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductTypeDto>
    {
    }
}
