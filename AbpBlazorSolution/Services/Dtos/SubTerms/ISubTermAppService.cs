using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.SubTerm
{
    public interface ISubTermAppService : ICrudAppService<SubTermDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSubTermDto>
    {
    }
}
