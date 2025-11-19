using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Employees
{
    public class EmployeesAppService : CrudAppService<Employee, EmployeesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEmployeeDto>, IEmployeeAppService
    {
        public EmployeesAppService(IRepository<Employee, Guid> repository) : base(repository)
        {
        }
    }
}
