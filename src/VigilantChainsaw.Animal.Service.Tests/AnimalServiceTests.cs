using NUnit.Framework;
using System.Threading.Tasks;

namespace VigilantChainsaw.Animal.Service.Tests
{
    [TestFixture]
    public class AnimalServiceTests
    {
        [Test]
        public async Task GetByName_WithValidName_ShouldReturnAnimalWithSameName()
        {
            // ARRANGE
            var name = "Fox";
            var service = new AnimalService();

            // ACT
            var actual = await service.GetByName(name);

            // ASSERT
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Name, Is.EqualTo(name));
        }

        [Test]
        public async Task GetByName_WithInvalidName_ShouldReturnNull()
        {
            // ARRANGE
            var name = "Dragon";
            var service = new AnimalService();

            // ACT
            var actual = await service.GetByName(name);

            // ASSERT
            Assert.That(actual, Is.Null);
        }
    }
}
