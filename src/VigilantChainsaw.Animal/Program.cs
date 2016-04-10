using VigilantChainsaw.Animal.Service;
using VigilantChainsaw.Framework;
using VigilantChainsaw.Common.Animal;

namespace VigilantChainsaw.Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MicroserviceConfiguration
            {
                Name = "VigilantChainsaw.Animal",
                Port = "3579",
                ConfigureApplicationContainer = c =>
                    {
                        c.Register<IAnimalService, AnimalService>().AsSingleton();
                    }
            };
            Microservice.Start(config);
        }
    }
}
