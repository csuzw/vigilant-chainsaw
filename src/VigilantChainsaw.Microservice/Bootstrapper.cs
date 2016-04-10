using Nancy;
using Nancy.TinyIoc;

namespace VigilantChainsaw.Framework
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private readonly IMicroserviceConfiguration _config;

        public Bootstrapper(IMicroserviceConfiguration config) : base()
        {
            StaticConfiguration.DisableErrorTraces = false;
            _config = config;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            _config.ConfigureApplicationContainer?.Invoke(container);
        }
    }
}
