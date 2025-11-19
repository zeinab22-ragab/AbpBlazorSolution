using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Competition
{
    public interface ICompetitionAppService : ICrudAppService<CompetitionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCompetitionDto>
    {
    }
}
