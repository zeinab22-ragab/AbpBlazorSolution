using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Supplier;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Suppliers
{
    public class SupplierAppService : CrudAppService<Supplier, SupplierDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSupplierDto> , ISupplierAppService
    {
        public SupplierAppService(IRepository<Supplier, Guid> repository) : base(repository)
        {
        }
    }
}
