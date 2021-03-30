using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace OrderManagement.Samples
{
    [RemoteService]
    [Route("api/OrderManagement")]
    public class OrderController : OrderManagementController, IOrderAppService
    {
        private readonly IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpGet]
        public async Task<OrderDto> GetAsync()
        {
            return await _orderAppService.GetAsync();
        }

        [HttpGet]
        [Route("authorized")]
        [Authorize]
        public async Task<OrderDto> GetAuthorizedAsync()
        {
            return await _orderAppService.GetAsync();
        }
    }
}
