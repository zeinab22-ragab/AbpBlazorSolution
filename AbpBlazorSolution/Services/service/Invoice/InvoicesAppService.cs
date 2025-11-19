using AbpBlazorSolution.Services.Dtos.Invoice;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpBlazorSolution.Services.service.Invoice
{
    public class InvoicesAppService : CrudAppService<Entities.Invoice, InvoicesDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDto> , IInvoiceAppService
    {
        public InvoicesAppService(IRepository<Entities.Invoice, Guid> repository) : base(repository)
        {
        }
    }
}
