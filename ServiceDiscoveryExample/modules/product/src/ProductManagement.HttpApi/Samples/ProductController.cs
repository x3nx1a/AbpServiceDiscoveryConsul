using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Samples;
using Volo.Abp;

namespace ProductManagement.Samples
{
    [RemoteService]
    [Route("api/ProductManagement")]
    public class ProductController : ProductManagementController, IProductAppService
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public async Task<ProductDto> GetAsync()
        {
            return await _productAppService.GetAsync();
        }

        [HttpGet]
        [Route("order")]
        public async Task<OrderDto> GetOrderAsync()
        {
            return await _productAppService.GetOrderAsync();
        }

        [HttpGet]
        [Route("authorized")]
        [Authorize]
        public async Task<ProductDto> GetAuthorizedAsync()
        {
            return await _productAppService.GetAsync();
        }
    }
}
