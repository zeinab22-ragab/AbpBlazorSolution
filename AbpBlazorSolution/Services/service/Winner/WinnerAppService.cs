using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Winner;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Winner
{
    public class WinnerAppService : CrudAppService<Entities.Winner, WinnerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWinnerDto>, IWinnerAppService
    {
        public WinnerAppService(IRepository<Entities.Winner, Guid> repository) : base(repository)
        {
        }
    }

}
