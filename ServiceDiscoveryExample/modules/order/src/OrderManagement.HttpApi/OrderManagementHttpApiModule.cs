using Localization.Resources.AbpUi;
using OrderManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace OrderManagement
{
    [DependsOn(
        typeof(OrderManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class OrderManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OrderManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<OrderManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
