using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Winner;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Winners
{
    public class WinnerAppService : CrudAppService<Winner, WinnerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWinnerDto>, IWinnerAppService
    {
        public WinnerAppService(IRepository<Winner, Guid> repository) : base(repository)
        {
        }
    }

}
