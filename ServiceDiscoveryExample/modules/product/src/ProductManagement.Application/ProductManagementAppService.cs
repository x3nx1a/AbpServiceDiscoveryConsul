using ProductManagement.Localization;
using Volo.Abp.Application.Services;

namespace ProductManagement
{
    public abstract class ProductManagementAppService : ApplicationService
    {
        protected ProductManagementAppService()
        {
            LocalizationResource = typeof(ProductManagementResource);
            ObjectMapperContext = typeof(ProductManagementApplicationModule);
        }
    }
}
