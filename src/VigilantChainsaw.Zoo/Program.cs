using VigilantChainsaw.Framework;
using VigilantChainsaw.Common.Zoo;
using VigilantChainsaw.Zoo.Service;
using VigilantChainsaw.Framework.ServiceDiscovery;
using VigilantChainsaw.Common.Framework;

namespace VigilantChainsaw.Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MicroserviceConfiguration
            {
                Name = "VigilantChainsaw.Zoo",
                Port = "3580",
                ConfigureApplicationContainer = c =>
                {
                    c.Register<IServiceHelper, ServiceHelper>().AsSingleton();
                    c.Register<IZooService, ZooService>().AsSingleton();
                }
            };
            Microservice.Start(config);
        }
    }
}
