using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Winner
{
    public interface IWinnerAppService : ICrudAppService<WinnerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWinnerDto>
    {
    }
}
