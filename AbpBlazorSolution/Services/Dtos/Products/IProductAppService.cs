using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Product
{
    public interface IProductAppService : ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>
    {
    }
}
