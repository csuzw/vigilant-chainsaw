using System.Threading.Tasks;

namespace VigilantChainsaw.Common.Animal
{
    public interface IAnimalService
    {
        Task<Animal> GetByName(string name);
    }
}
