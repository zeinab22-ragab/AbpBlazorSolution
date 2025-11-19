using AbpBlazorSolution.Services.Dtos.Activity;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Activity
{
    public class ActivityAppService : CrudAppService<Entities.Activity, ActivityDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateActivirtDto>, IActivityAppService
    {
        public ActivityAppService(IRepository<Entities.Activity, Guid> repository) : base(repository)
        {
        }
    }
}
