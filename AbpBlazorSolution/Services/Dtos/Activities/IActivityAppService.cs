using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Activity
{
    public interface IActivityAppService : ICrudAppService<ActivityDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateActivirtDto>
    {
    }
}
