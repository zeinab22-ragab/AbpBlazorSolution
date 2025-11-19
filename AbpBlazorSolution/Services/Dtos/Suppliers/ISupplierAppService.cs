using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Supplier
{
    public interface ISupplierAppService : ICrudAppService<SupplierDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSupplierDto>
    {
    }
}
