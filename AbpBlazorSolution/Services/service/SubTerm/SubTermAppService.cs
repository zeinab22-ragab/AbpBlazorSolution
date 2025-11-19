using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.SubTerm;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.SubTerms
{
    public class SubTermAppService : CrudAppService<SubTerm, SubTermDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSubTermDto>, ISubTermAppService
    {
        public SubTermAppService(IRepository<SubTerm, Guid> repository) : base(repository)
        {
        }
    }
}
