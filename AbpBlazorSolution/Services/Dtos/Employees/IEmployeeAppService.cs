using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Employee
{
    public interface IEmployeeAppService : ICrudAppService<EmployeesDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateEmployeeDto>
    {
    }
}
