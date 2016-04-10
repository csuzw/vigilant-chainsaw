using NUnit.Framework;
using System;
using System.Reflection;

namespace VigilantChainsaw.Services.Root.Tests
{
    [TestFixture]
    public class RootServiceTests
    {
        [Test]
        public void Get_ShouldReturnHelloWorld()
        {
            // ARRANGE
            var service = new RootService();

            // ACT
            var actual = service.Get();

            // ASSERT
            Assert.That(actual, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void GetOperatingSystem_ShouldReturnOperatingSystemVersion()
        {
            // ARRANGE
            var service = new RootService();

            // ACT
            var actual = service.GetOperatingSystem();

            // ASSERT
            Assert.That(actual, Is.EqualTo(Environment.OSVersion.ToString()));
        }

        [Test]
        public void GetVersion_ShouldReturnAssemblyVersion()
        {
            // ARRANGE
            var service = new RootService();

            // ACT
            var actual = service.GetVersion();

            // ASSERT
            Assert.That(actual, Is.EqualTo(Assembly.GetExecutingAssembly().GetName().Version.ToString()));
        }
    }
}
