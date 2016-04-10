using System.Threading.Tasks;

namespace VigilantChainsaw.Common.Framework
{
    public interface IServiceHelper
    {
        Task<TResponse> Get<TResponse>(string service, string resource);
    }
}
