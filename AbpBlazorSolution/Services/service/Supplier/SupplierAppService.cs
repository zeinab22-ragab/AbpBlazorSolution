using AbpBlazorSolution.Services.Dtos.Supplier;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Supplier
{
    public class SupplierAppService : CrudAppService<Entities.Supplier, SupplierDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSupplierDto> , ISupplierAppService
    {
        public SupplierAppService(IRepository<Entities.Supplier, Guid> repository) : base(repository)
        {
        }
    }
}
