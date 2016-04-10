using Owin;
using System.Web.Http;

namespace VigilantChainsaw.Application
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            // configuration
            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.MapHttpAttributeRoutes();

            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}
