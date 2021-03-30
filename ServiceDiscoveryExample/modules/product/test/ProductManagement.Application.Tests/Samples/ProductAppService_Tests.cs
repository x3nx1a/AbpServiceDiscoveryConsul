using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ProductManagement.Samples
{
    public class ProductAppService_Tests : ProductManagementApplicationTestBase
    {
        private readonly IProductAppService _productAppService;

        public ProductAppService_Tests()
        {
            _productAppService = GetRequiredService<IProductAppService>();
        }

        [Fact]
        public async Task GetAsync()
        {
            var result = await _productAppService.GetAsync();
            result.Value.ShouldBe(42);
        }

        [Fact]
        public async Task GetAuthorizedAsync()
        {
            var result = await _productAppService.GetAuthorizedAsync();
            result.Value.ShouldBe(42);
        }
    }
}
