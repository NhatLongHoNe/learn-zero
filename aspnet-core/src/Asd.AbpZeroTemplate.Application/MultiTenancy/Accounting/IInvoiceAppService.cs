using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Asd.AbpZeroTemplate.MultiTenancy.Accounting.Dto;

namespace Asd.AbpZeroTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
