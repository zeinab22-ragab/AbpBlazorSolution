using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Employee
{
    public class EmployeesAppService : CrudAppService<Entities.Employee, EmployeesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEmployeeDto>, IEmployeeAppService
    {
        public EmployeesAppService(IRepository<Entities.Employee, Guid> repository) : base(repository)
        {
        }
    }
}
