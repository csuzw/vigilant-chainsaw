using NUnit.Framework;
using System;

namespace VigilantChainsaw.Services.Index.Tests
{
    [TestFixture]
    public class IndexServiceTests
    {
        [Test]
        public void Get_ShouldReturnHelloWorld()
        {
            // ARRANGE
            var service = new IndexService();

            // ACT
            var actual = service.Get();

            // ASSERT
            Assert.That(actual, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void GetOperatingSystem_ShouldReturnOperatingSystemVersion()
        {
            // ARRANGE
            var service = new IndexService();

            // ACT
            var actual = service.GetOperatingSystem();

            // ASSERT
            Assert.That(actual, Is.EqualTo(Environment.OSVersion.ToString()));
        }
    }
}
