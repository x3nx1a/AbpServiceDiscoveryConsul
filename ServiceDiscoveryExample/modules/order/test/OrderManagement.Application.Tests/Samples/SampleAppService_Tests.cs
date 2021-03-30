using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace OrderManagement.Samples
{
    public class SampleAppService_Tests : OrderManagementApplicationTestBase
    {
        private readonly IOrderAppService _orderAppService;

        public SampleAppService_Tests()
        {
            _orderAppService = GetRequiredService<IOrderAppService>();
        }

        [Fact]
        public async Task GetAsync()
        {
            var result = await _orderAppService.GetAsync();
            result.Value.ShouldBe(42);
        }

        [Fact]
        public async Task GetAuthorizedAsync()
        {
            var result = await _orderAppService.GetAuthorizedAsync();
            result.Value.ShouldBe(42);
        }
    }
}
