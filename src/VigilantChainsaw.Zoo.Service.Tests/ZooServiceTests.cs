using NUnit.Framework;
using System.Threading.Tasks;
using VigilantChainsaw.Common.Framework;

namespace VigilantChainsaw.Zoo.Service.Tests
{
    using Moq;
    using Animal = Common.Animal.Animal;

    [TestFixture]
    public class ZooServiceTests
    {
        [Test]
        public async Task GetSoundByName_WithValidName_ShouldReturnSound()
        {
            // ARRANGE
            var name = "Fox";
            var sound = "Wa-pa-pa-pa-pa-pa-pow!";
            var serviceHelper = new Mock<IServiceHelper>();
            serviceHelper.Setup(i => i.Get<Animal>(It.IsAny<string>(), name)).Returns(Task.FromResult(new Animal { Name = name, Sound = sound }));
            var service = new ZooService(serviceHelper.Object);

            // ACT
            var actual = await service.GetSoundByName(name);

            // ASSERT
            Assert.That(actual, Is.EqualTo(sound));
        }
        [Test]
        public async Task GetSoundByName_WithInvalidName_ShouldReturnEmptyString()
        {
            // ARRANGE
            var name = "Dragon";
            var serviceHelper = new Mock<IServiceHelper>();
            serviceHelper.Setup(i => i.Get<Animal>(It.IsAny<string>(), name)).Returns(Task.FromResult<Animal>(null));
            var service = new ZooService(serviceHelper.Object);

            // ACT
            var actual = await service.GetSoundByName(name);

            // ASSERT
            Assert.That(actual, Is.Empty);
        }
    }
}
