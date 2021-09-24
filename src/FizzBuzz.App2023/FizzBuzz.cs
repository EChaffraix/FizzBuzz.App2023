namespace FizzBuzz.App2023
{
    public class FizzBuzz : IFizzBuzz
    {
        IRule[] rules;

        public FizzBuzz()
        {
            rules = new[]
            {
                new ModuloRule(3, "Fizz"),
                new ModuloRule(5, "Buzz")
            };
        }

        public FizzBuzz(IRule[] rules)
        {
            this.rules = rules;
        }

        public string Play(int i)
        {
            string result = string.Empty;
            foreach (var rule in rules)
            {
                result += rule.Apply(i);
            }
            if (result == string.Empty)
                return i.ToString();
            return result;
        }
    }
}
