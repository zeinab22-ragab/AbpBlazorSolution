using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Status
{
    public interface IStatusAppService : ICrudAppService<StatusDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStatusDto>
    {
    }
}
