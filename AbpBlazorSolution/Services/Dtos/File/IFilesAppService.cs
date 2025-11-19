using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.File
{
    public interface IFilesAppService : ICrudAppService<FilesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateFilesDto>
    {
    }
}
