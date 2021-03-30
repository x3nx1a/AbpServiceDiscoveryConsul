using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ProductManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ProductManagementDomainSharedModule)
    )]
    public class ProductManagementDomainModule : AbpModule
    {

    }
}
