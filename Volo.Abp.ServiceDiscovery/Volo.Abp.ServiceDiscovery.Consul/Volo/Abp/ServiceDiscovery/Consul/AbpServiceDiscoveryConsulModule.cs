using System;
using System.Threading;
using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp.Modularity;

namespace Volo.Abp.ServiceDiscovery.Consul
{
    public class AbpServiceDiscoveryConsulModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var config = context.Services.GetConfiguration().GetSection("Consul:ServiceDiscovery");
            Configure<AbpConsulServiceDiscoveryOptions>(config);
            
            var consulClient = new ConsulClient(cfg =>
            {
                cfg.Address = config.GetValue<Uri>("DiscoveryAddress");
            });;

            context.Services.AddSingleton<IConsulClient>(s => consulClient);
        } 
 

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var service = context.ServiceProvider.GetRequiredService<ServiceDiscoveryHostedService>();
            
            service.StartAsync(new CancellationToken()).GetAwaiter().GetResult();
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            var service = context.ServiceProvider.GetRequiredService<ServiceDiscoveryHostedService>();
            
            service.StopAsync(new CancellationToken()).GetAwaiter().GetResult();
        }
    }
}