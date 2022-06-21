using System.Threading.Tasks;
using Abp.Dependency;

namespace Asd.AbpZeroTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}