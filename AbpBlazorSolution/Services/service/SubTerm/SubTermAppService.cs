using AbpBlazorSolution.Services.Dtos.SubTerm;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.SubTerm
{
    public class SubTermAppService : CrudAppService<Entities.SubTerm, SubTermDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSubTermDto>, ISubTermAppService
    {
        public SubTermAppService(IRepository<Entities.SubTerm, Guid> repository) : base(repository)
        {
        }
    }
}
