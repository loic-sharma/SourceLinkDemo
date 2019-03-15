using System;

namespace SourceLinkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = ChooseHandler();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter two integers:");

                try
                {
                    var left = Console.ReadLine();
                    var right = Console.ReadLine();

                    var result = handler(int.Parse(left), int.Parse(right));

                    Console.WriteLine();
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        public static Func<int, int, int> ChooseHandler()
        {
            while (true)
            {
                Console.WriteLine("Please select which demo you would like to run:");
                Console.WriteLine(@"1. ""Bad"" demo");
                Console.WriteLine(@"2. ""Good"" demo");

                var selection = Console.ReadLine();
                if (int.TryParse(selection, out var result))
                {
                    if (result == 1)
                    {
                        return BadDependency.Math.Add;
                    }
                    else if (result == 2)
                    {
                        return GoodDependency.Math.Add;
                    }
                }

                Console.WriteLine($"Invalid selection '{selection}', please enter either '1' or '2'");
                Console.WriteLine();
            }
        }
    }
}
