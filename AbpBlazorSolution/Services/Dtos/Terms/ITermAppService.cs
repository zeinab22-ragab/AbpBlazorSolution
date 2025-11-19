using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Term
{
    public interface ITermAppService : ICrudAppService<TermDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTermDto>
    {
    }
}
