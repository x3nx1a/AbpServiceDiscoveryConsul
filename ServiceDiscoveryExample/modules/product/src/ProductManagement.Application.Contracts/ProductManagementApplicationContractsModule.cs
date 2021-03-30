using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ProductManagement
{
    [DependsOn(
        typeof(ProductManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ProductManagementApplicationContractsModule : AbpModule
    {

    }
}
