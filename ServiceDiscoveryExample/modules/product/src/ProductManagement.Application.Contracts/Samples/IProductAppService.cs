using System.Threading.Tasks;
using OrderManagement.Samples;
using Volo.Abp.Application.Services;

namespace ProductManagement.Samples
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> GetAsync();
        Task<OrderDto> GetOrderAsync();

        Task<ProductDto> GetAuthorizedAsync();
    }
}
