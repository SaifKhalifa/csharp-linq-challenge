using System.Threading.Channels;

namespace linq_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 8, 10, 13, 20, -1, 7};

            // Q1: Return all numbers that are greater than "5" and sort them in descending order.
            var numbersGreaterThanFive = 
                numbers
                .Where(n => n > 5)
                //.OrderBy(n => n).Reverse()
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine("Q1: Return all numbers that are greater than 5 and sort them in descending order.");
            Console.WriteLine($"Answer: {string.Join(", ", numbersGreaterThanFive)}");


            /*
             * Q2: Determine whether:
                1. All numbers are positive.
                2. At least one number is divisible by "7".

             * Return both results.
            */

            // Q2.1
            bool areAllNumbersPositive =
                numbers
                .All(n => n > 0);

            Console.WriteLine("Q2.1: Is all numbers positive?");
            Console.WriteLine(areAllNumbersPositive); // false, since the array contains '-1'

            // Q2.2
            // approach 1: returns BOOLEAN value if there are any value.
            bool isDivisbleBySeven =
                numbers
                .Any(n => n % 7 == 0);
                
            //approach 2: check and get the value.
            int? divisableNumber = 
                numbers.FirstOrDefault(n => n % 7 == 0);

            Console.WriteLine("Q2.2: Is there any number divisible by 7?");

            if (divisableNumber != 0) // the default value will be 0 if there's nothing returned from the query
            {
                Console.WriteLine($"Yes, the number '{divisableNumber}' is divisiable by '7'");
            }
            else
            {
                Console.WriteLine(isDivisbleBySeven);
            }

            // prevent console from exiting rightaway.
            Console.ReadLine();
        }
    }
}
