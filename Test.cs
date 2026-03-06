using NUnit.Framework;

namespace VrKayak.Tests
{
    public class PlaceholderTests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass("Placeholder test passed");
        }

        [Test]
        public void Test2()
        {
            Assert.That(2 + 2, Is.EqualTo(14));
        }
    }
}
