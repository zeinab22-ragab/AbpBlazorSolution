using AbpBlazorSolution.Services.Dtos.Competition;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Competition
{
    public class CompetetitionAppService : CrudAppService<Entities.Competition, CompetitionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCompetitionDto>, ICompetitionAppService
    {
        public CompetetitionAppService(IRepository<Entities.Competition, Guid> repository) : base(repository)
        {
        }
    }
}
