using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace OrderManagement.Samples
{
    public interface IOrderAppService : IApplicationService
    {
        Task<OrderDto> GetAsync();

        Task<OrderDto> GetAuthorizedAsync();
    }
}
