using AbpBlazorSolution.Services.Dtos.Employee;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpBlazorSolution.Services.Dtos.Invoice
{
    public interface IInvoiceAppService : ICrudAppService<InvoicesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDto>
    {
    }
}
