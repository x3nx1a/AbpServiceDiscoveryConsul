using Microsoft.Extensions.DependencyInjection;
using OrderManagement;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Http.Client;

namespace ProductManagement
{
    [DependsOn(
        typeof(ProductManagementDomainModule),
        typeof(ProductManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpHttpClientModule),
        typeof(OrderManagementHttpApiClientModule)
        )]
    public class ProductManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<ProductManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ProductManagementApplicationModule>(validate: true);
            });
        }
    }
}
