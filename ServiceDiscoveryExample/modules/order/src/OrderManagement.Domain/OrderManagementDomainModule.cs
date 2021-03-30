using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace OrderManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OrderManagementDomainSharedModule)
    )]
    public class OrderManagementDomainModule : AbpModule
    {

    }
}
