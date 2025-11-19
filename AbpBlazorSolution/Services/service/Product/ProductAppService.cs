using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Product;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto> , IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
        }
    }
}
