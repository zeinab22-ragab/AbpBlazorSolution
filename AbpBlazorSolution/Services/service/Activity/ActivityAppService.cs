using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Activity;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Activities
{
    public class ActivityAppService : CrudAppService<Activity, ActivityDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateActivirtDto>, IActivityAppService
    {
        public ActivityAppService(IRepository<Activity, Guid> repository) : base(repository)
        {
        }
    }
}
