using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using OrderManagement.Samples;

namespace ProductManagement.Samples
{
    public class ProductAppService : ProductManagementAppService, IProductAppService
    {
        private readonly IOrderAppService _orderAppService;

        public ProductAppService(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }
        
        public Task<ProductDto> GetAsync()
        {
            return Task.FromResult(
                new ProductDto
                {
                    Value = 42
                }
            );
        }

        public async Task<OrderDto> GetOrderAsync()
        {
            return await _orderAppService.GetAsync();
        }

        [Authorize]
        public Task<ProductDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new ProductDto
                {
                    Value = 42
                }
            );
        }
    }
}