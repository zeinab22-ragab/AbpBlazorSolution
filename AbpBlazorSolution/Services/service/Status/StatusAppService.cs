using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Status;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Statuses
{
    public class StatusAppService : CrudAppService<Status, StatusDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStatusDto> ,IStatusAppService
    {
        public StatusAppService(IRepository<Status, Guid> repository) : base(repository)
        {
        }
    }
}
