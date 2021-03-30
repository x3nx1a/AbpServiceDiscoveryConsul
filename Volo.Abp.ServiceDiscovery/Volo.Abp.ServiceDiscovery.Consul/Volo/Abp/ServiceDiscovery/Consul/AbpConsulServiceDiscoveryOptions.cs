using System;

namespace Volo.Abp.ServiceDiscovery.Consul
{
    public class AbpConsulServiceDiscoveryOptions
    {
        public Uri DiscoveryAddress { get; set; }
        public Uri ServiceAddress { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
    
}