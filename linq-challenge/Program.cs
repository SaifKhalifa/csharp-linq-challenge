using System.Threading.Channels;

namespace linq_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 8, 10, 13, 20 };

            // Q1: Return all numbers that are greater than "5" and sort them in descending order.
            var numbersGreaterThanFive = 
                numbers
                .Where(n => n > 5)
                //.OrderBy(n => n).Reverse()
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine("Q1: Return all numbers that are greater than 5 and sort them in descending order.");
            Console.WriteLine($"Answer: {string.Join(", ", numbersGreaterThanFive)}");

            // prevent console from exiting rightaway.
            Console.ReadLine();
        }
    }
}
