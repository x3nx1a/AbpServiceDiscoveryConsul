using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ProductManagement
{
    [DependsOn(
        typeof(ProductManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProductManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
