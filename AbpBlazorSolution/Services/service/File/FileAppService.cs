using AbpBlazorSolution.Services.Dtos.File;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Files
{
    public class FileAppService : CrudAppService<Entities.File, FilesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateFilesDto>, IFilesAppService
    {
        public FileAppService(IRepository<Entities.File, Guid> repository) : base(repository)
        {
        }
    }
}
