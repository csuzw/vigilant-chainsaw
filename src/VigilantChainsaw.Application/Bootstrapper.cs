using Nancy;
using Nancy.TinyIoc;
using VigilantChainsaw.Services.Index;

namespace VigilantChainsaw.Application
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            container.Register<IIndexService, IndexService>().AsSingleton();
        }
    }
}