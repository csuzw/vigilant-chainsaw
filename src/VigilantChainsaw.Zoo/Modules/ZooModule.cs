using Nancy;
using VigilantChainsaw.Common.Zoo;

namespace VigilantChainsaw.Zoo.Modules
{
    public class ZooModule : NancyModule
    {
        public ZooModule(IZooService service)
        {
            Get["sound/{name}", true] = async (_, ct) => await service.GetSoundByName(_.name);
        }
    }
}
