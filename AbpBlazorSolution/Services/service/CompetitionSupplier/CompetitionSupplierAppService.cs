using AbpBlazorSolution.Services.Dtos.Competition;
using AbpBlazorSolution.Services.Dtos.CompetitionSupplier;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.CompetitionSupplier
{
    public class CompetitionSupplierAppService : CrudAppService<Entities.CompetitionSupplier, CompetitionSupplierDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCompetitionSupplierDto>, ICompetitionSupplierAppService
    {
        public CompetitionSupplierAppService(IRepository<Entities.CompetitionSupplier, Guid> repository) : base(repository)
        {
        }
    }
}
