using OrderManagement.Localization;
using Volo.Abp.Application.Services;

namespace OrderManagement
{
    public abstract class OrderManagementAppService : ApplicationService
    {
        protected OrderManagementAppService()
        {
            LocalizationResource = typeof(OrderManagementResource);
            ObjectMapperContext = typeof(OrderManagementApplicationModule);
        }
    }
}
