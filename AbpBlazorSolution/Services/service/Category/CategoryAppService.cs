using AbpBlazorSolution.Services.Dtos.Category;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Category
{
    public class CategoryAppService : CrudAppService<Entities.Category, CategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Entities.Category, Guid> repository) : base(repository)
        {
        }
    }
}
