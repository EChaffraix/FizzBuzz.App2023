using NUnit.Framework;

namespace FizzBuzz.App2023.Tests
{
    [TestFixture]
    public class Foo
    {
        [Test]
        public void Bar()
        {
            int i = 41;
            i++;
            Assert.That(i, Is.EqualTo(42));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(40)]
        public void FooBar(int i)
        {
            i++;
            Assert.That(i, Is.LessThan(42));
        }

    }
}
