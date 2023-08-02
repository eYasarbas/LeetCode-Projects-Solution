namespace Roman_to_Integer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            const string roman = "CLXXXIX";

            Solution solution =new();
            Console.WriteLine(solution.RomanToInt(roman));
        }
    }
}
