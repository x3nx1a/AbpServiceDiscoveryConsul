using System.Threading;
using System.Threading.Tasks;
using Consul;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.ServiceDiscovery.Consul
{
    public class ServiceDiscoveryHostedService : ISingletonDependency
    {
        private readonly IConsulClient _client;
        private string _registrationId;
        protected AbpConsulServiceDiscoveryOptions AbpConsulServiceDiscoveryOptions { get; }

        public ServiceDiscoveryHostedService(IConsulClient client, IOptions<AbpConsulServiceDiscoveryOptions> options)
        {
            _client = client;
            AbpConsulServiceDiscoveryOptions = options.Value;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _registrationId = $"{AbpConsulServiceDiscoveryOptions.Name}-{AbpConsulServiceDiscoveryOptions.Id}";

            var registration = new AgentServiceRegistration
            { 
                ID = _registrationId,
                Name = AbpConsulServiceDiscoveryOptions.Name,
                Address = AbpConsulServiceDiscoveryOptions.ServiceAddress.Host,
                Port = AbpConsulServiceDiscoveryOptions.ServiceAddress.Port 
            };

            await _client.Agent.ServiceDeregister(registration.ID, cancellationToken);
            await _client.Agent.ServiceRegister(registration, cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await _client.Agent.ServiceDeregister(_registrationId, cancellationToken);
        }
    }
}