using System.Threading.Tasks;

namespace VigilantChainsaw.Common.Zoo
{
    public interface IZooService
    {
        Task<string> GetSoundByName(string name);
    }
}
