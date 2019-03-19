using System;

namespace SourceLinkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dependency = ChooseDependency();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter two integers:");

                try
                {
                    var left = int.Parse(Console.ReadLine());
                    var right = int.Parse(Console.ReadLine());

                    var result = dependency(left, right);

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

        public static Func<int, int, int> ChooseDependency()
        {
            while (true)
            {
                Console.WriteLine("Please select which demo you would like to run:");
                Console.WriteLine(@"1. ""Bad"" demo");
                Console.WriteLine(@"2. ""Good"" demo");

                switch (Console.ReadLine())
                {
                    case "1": return BadDependency.Math.Add;
                    case "2": return GoodDependency.Math.Add;
                }

                Console.WriteLine($"Invalid selection, please enter either '1' or '2'");
                Console.WriteLine();
            }
        }
    }
}
