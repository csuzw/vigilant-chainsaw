using Nancy;
using VigilantChainsaw.Common.Animal;

namespace VigilantChainsaw.Animal.Modules
{
    public class AnimalModule : NancyModule
    {
        public AnimalModule(IAnimalService service)
        {
            Get["/{name}", true] = async (_, ct) =>
            {
                var animal = await service.GetByName((string)_.name);
                return Response.AsJson(animal);
            };
        }
    }
}
