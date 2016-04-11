using Consul;
using RestSharp;
using System;
using System.Linq;
using System.Threading.Tasks;
using VigilantChainsaw.Common.Framework;

namespace VigilantChainsaw.Framework.ServiceDiscovery
{
    public class ServiceHelper : IServiceHelper
    {
        public async Task<TResponse> Get<TResponse>(string service, string resource)
        {
            var url = await GetServiceUrl(service);
            if (string.IsNullOrWhiteSpace(url)) return default(TResponse);

            var client = new RestClient(url);
            var request = new RestRequest(resource, Method.GET);
            var response = await client.ExecuteGetTaskAsync<TResponse>(request);

            return response != null ? response.Data : default(TResponse);
        }

        private async Task<string> GetServiceUrl(string name)
        {
            var config = new ConsulClientConfiguration
            {
                Address = new Uri("http://consul:8500")
            };
            using (var client = new ConsulClient(config))
            {
                var response = await client.Health.Service(name, string.Empty, passingOnly: true);
                var serviceEntry = response.Response != null ? response.Response.FirstOrDefault() : null;
                return (serviceEntry != null)
                    ? string.Format("http://{0}:{1}", serviceEntry.Service.Address, serviceEntry.Service.Port)
                    : string.Empty;
            }
        }
    }
}
