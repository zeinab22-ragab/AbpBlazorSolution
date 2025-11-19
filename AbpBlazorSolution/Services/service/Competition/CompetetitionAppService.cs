using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Competition;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Competitions
{
    public class CompetetitionAppService : CrudAppService<Competition, CompetitionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCompetitionDto>, ICompetitionAppService
    {
        public CompetetitionAppService(IRepository<Competition, Guid> repository) : base(repository)
        {
        }
    }
}
