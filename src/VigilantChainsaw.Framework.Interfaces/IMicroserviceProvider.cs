using System.Threading.Tasks;

namespace VigilantChainsaw.Framework.Interfaces
{
    public interface IMicroserviceProvider
    {
        Task<string> GetService(string name);
    }
}
