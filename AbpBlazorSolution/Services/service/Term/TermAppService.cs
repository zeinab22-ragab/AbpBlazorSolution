using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Term;
using AbpBlazorSolution.Services.Dtos.Winner;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Terms
{
    public class TermAppService : CrudAppService<Term, TermDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTermDto>, ITermAppService

    {
        public TermAppService(IRepository<Term, Guid> repository) : base(repository)
        {
        }
    }
}
