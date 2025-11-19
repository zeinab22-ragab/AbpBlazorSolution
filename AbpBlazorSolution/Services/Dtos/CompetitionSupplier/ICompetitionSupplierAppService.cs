using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.CompetitionSupplier
{
    public interface ICompetitionSupplierAppService : ICrudAppService<CompetitionSupplierDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCompetitionSupplierDto>
    {
    }
}
