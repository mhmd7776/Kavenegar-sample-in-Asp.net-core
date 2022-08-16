namespace KavenegarSample.Utilities
{
    public static class Generator
    {
        public static string RandomNumber()
        {
            var generator = new Random();

            var result = generator.Next(0, 100000).ToString("D5");

            return result;
        }
    }
}
