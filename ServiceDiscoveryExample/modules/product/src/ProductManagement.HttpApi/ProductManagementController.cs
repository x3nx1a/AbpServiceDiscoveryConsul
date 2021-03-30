using ProductManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductManagement
{
    public abstract class ProductManagementController : AbpController
    {
        protected ProductManagementController()
        {
            LocalizationResource = typeof(ProductManagementResource);
        }
    }
}
