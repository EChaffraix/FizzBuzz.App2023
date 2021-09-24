using NUnit.Framework;

namespace FizzBuzz.App2023.Tests
{
    [TestFixture]
    class FizzBuzzTester
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(7)]
        public void WhenTheNumberIsASimpleNumber_ThenTheResultMustBeTheNumber(int i)
        {
            IFizzBuzz game = new FizzBuzz();

            string result = game.Play(i);

            Assert.That(result, Is.EqualTo(i.ToString()));
        }

        [TestCase(3)]
        [TestCase(99)]
        public void WhenTheNumberIsAMultipleOf3_ThenTheResultMustBeFizz(int i)
        {
            IFizzBuzz game = new FizzBuzz();

            string result = game.Play(i);

            Assert.That(result, Is.EqualTo("Fizz"));
        }


        [TestCase(5)]
        [TestCase(55)]
        [TestCase(100)]
        public void WhenTheNumberIsAMultipleOf5_ThenTheResultMustBeBuzz(int i)
        {
            IFizzBuzz game = new FizzBuzz();

            string result = game.Play(i);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(45)]
        [TestCase(90)]
        public void WhenTheNumberIsAMultipleOf5And3_ThenTheResultMustBeFizzBuzz(int i)
        {
            IFizzBuzz game = new FizzBuzz();

            string result = game.Play(i);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }

    [TestFixture]
    public class ModuloRuleTester
    {
        [TestCase(14)]
        [TestCase(21)]
        [TestCase(7)]
        public void WhenNumberIsAModuloOfTheRule_ThenReturnTheExpectedValue(int i)
        {
            const string expected = "Tazz";
            var rule = new ModuloRule(7, expected);
            var result = rule.Apply(i);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(15)]
        [TestCase(22)]
        [TestCase(8)]
        public void WhenNumberIsNotAModuloOfTheRule_ThenReturnAnEmptyString(int i)
        {
            var rule = new ModuloRule(7, "lol");
            var result = rule.Apply(i);
            Assert.That(result, Is.Empty);
        }
    }
}
