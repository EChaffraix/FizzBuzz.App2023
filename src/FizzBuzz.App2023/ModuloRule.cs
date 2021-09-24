namespace FizzBuzz.App2023
{
    public class ModuloRule : IRule
    {
        private readonly int modulo;
        private readonly string expected;

        public ModuloRule(int modulo, string expected)
        {
            this.modulo = modulo;
            this.expected = expected;
        }
        public string Apply(int i)
        {
            return i % modulo == 0 ? expected : string.Empty;
        }
    }
}
