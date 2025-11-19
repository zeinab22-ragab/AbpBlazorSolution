using AbpBlazorSolution.Services.Dtos.Customer;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Customer
{
    public class CustomerAppService : CrudAppService<Entities.Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto>, ICustomerAppService
    {
        public CustomerAppService(IRepository<Entities.Customer, Guid> repository) : base(repository)
        {
        }
    }
}
