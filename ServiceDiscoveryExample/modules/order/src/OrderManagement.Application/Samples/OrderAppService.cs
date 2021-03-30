using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace OrderManagement.Samples
{
    public class OrderAppService : OrderManagementAppService, IOrderAppService
    {
        public Task<OrderDto> GetAsync()
        {
            return Task.FromResult(
                new OrderDto
                {
                    Value = 52
                }
            );
        }

        [Authorize]
        public Task<OrderDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new OrderDto
                {
                    Value = 52
                }
            );
        }
    }
}