using AbpBlazorSolution.Services.Dtos.Term;
using AbpBlazorSolution.Services.Dtos.Winner;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Term
{
    public class TermAppService : CrudAppService<Entities.Term, TermDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTermDto>, ITermAppService

    {
        public TermAppService(IRepository<Entities.Term, Guid> repository) : base(repository)
        {
        }
    }
}
