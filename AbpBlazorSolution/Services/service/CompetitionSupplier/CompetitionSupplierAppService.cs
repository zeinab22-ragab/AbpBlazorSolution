using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Competition;
using AbpBlazorSolution.Services.Dtos.CompetitionSupplier;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.CompetitionSuppliers
{
    public class CompetitionSupplierAppService : CrudAppService<CompetitionSupplier, CompetitionSupplierDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCompetitionSupplierDto>, ICompetitionSupplierAppService
    {
        public CompetitionSupplierAppService(IRepository<CompetitionSupplier, Guid> repository) : base(repository)
        {
        }
    }
}
