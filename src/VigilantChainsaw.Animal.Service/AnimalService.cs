using System.Collections.Generic;
using System.Linq;
using VigilantChainsaw.Common.Animal;

namespace VigilantChainsaw.Animal.Service
{
    using System.Threading.Tasks;
    using Animal = Common.Animal.Animal;

    public class AnimalService : IAnimalService
    {
        private readonly List<Animal> _animals = new List<Animal>
        {
            new Animal { Name = "Duck", Sound = "Quack" },
            new Animal { Name = "Horse", Sound = "Neigh" },
            new Animal { Name = "Elephant", Sound = "Toot" },
            new Animal { Name = "Fox", Sound = "Wa-pa-pa-pa-pa-pa-pow!" },
            new Animal { Name = "Cat", Sound = "Moo" },
            new Animal { Name = "Dog", Sound = "Woof" },
            new Animal { Name = "Cow", Sound = "Moo" },
            new Animal { Name = "Sheep", Sound = "Baa" },
        };

        public async Task<Animal> GetByName(string name)
        {
            return await Task.Run(() => _animals.FirstOrDefault(a => a.Name == name));
        }
    }
}
