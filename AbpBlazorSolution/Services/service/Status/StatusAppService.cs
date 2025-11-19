using AbpBlazorSolution.Services.Dtos.Status;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Status
{
    public class StatusAppService : CrudAppService<Entities.Status, StatusDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStatusDto> ,IStatusAppService
    {
        public StatusAppService(IRepository<Entities.Status, Guid> repository) : base(repository)
        {
        }
    }
}
