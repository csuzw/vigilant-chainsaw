using Nancy;
using VigilantChainsaw.Services.Index;

namespace VigilantChainsaw.Application.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule(IIndexService service)
        {
            Get["/"] = _ => service.Get();
            Get["/os"] = _ => service.GetOperatingSystem();
            Get["/version"] = _ => service.GetVersion();
        } 
    }
}