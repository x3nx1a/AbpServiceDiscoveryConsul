using Volo.Abp.Modularity;

namespace OrderManagement
{
    [DependsOn(
        typeof(OrderManagementApplicationModule),
        typeof(OrderManagementDomainTestModule)
        )]
    public class OrderManagementApplicationTestModule : AbpModule
    {

    }
}
