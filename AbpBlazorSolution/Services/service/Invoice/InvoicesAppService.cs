using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Invoice;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Invoices
{
    public class InvoicesAppService : CrudAppService<Invoice, InvoicesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDto> , IInvoiceAppService
    {
        public InvoicesAppService(IRepository<Invoice, Guid> repository) : base(repository)
        {
        }
    }
}
