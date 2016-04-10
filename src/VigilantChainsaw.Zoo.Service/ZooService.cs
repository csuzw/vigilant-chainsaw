using System.Threading.Tasks;
using VigilantChainsaw.Common.Framework;
using VigilantChainsaw.Common.Zoo;

namespace VigilantChainsaw.Zoo.Service
{
    using Animal = Common.Animal.Animal;

    public class ZooService : IZooService
    {
        private readonly IServiceHelper _serviceHelper;
        
        public ZooService(IServiceHelper serviceHelper)
        {
            _serviceHelper = serviceHelper;
        }

        public async Task<string> GetSoundByName(string name)
        {
            var animal = await _serviceHelper.Get<Animal>("vigilant-chainsaw-animal", name);
            return animal != null ? animal.Sound : string.Empty;
        }
    }
}
