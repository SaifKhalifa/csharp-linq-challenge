namespace linq_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = new List<Order>
            {
                new Order(1, 101, new DateTime(2022, 9, 20), 125.50m),
                new Order(2, 101, new DateTime(2023, 9, 21), 79.99m),
                new Order(3, 102, new DateTime(2024, 9, 22), 245.75m),
                new Order(4, 103, new DateTime(2025, 9, 23), 42.50m),
                new Order(5, 104, new DateTime(2026, 9, 24), 156.25m),
                new Order(6, 105, new DateTime(2026, 9, 25), 310.00m),
                new Order(7, 105, new DateTime(2026, 9, 26), 34.99m)
            };

            /*
             * Q7:
                Find the top 3 customers based on their total order value.
                For each customer, return:
                    1. CustomerId
                    2. Total amount spent
                The result should be ordered by total amount spent in descending order.
             */

            var topThree =
                orders
                .GroupBy(o => o.CustomerId)
                .Select(ordr => new
                {
                    CustoemrId = ordr.Key,
                    TotalAmountSpent = ordr.Sum(o => o.Total)
                })
                .OrderByDescending(o => o.TotalAmountSpent)
                .Take(3);

            Console.WriteLine("Q7: top 3 customers based on their total order value.");
            foreach (var orderGroup in topThree)
            {
                Console.WriteLine($"CustoemrID: {orderGroup.CustoemrId}");
                Console.WriteLine($"Total Amount Spent: {orderGroup.TotalAmountSpent}");
            }


            /*
             * Q8:
                Find the customer who has placed the highest number of orders during the current year.
                Return:
                    1. CustomerId
                    2. Number of orders
                Only orders from the current year should be considered.
             */

            var topCustomer =
                orders
                .GroupBy(o => o.CustomerId)
                .Select(ordr => new
                {
                    CustoemrId = ordr.Key,

                    CurrentYearTotalOrders = 
                        ordr
                        .Where(o => o.Date.Year == DateTime.Now.Year)
                        .Count()
                })
                .OrderByDescending(o => o.CurrentYearTotalOrders)
                .Take(1);

            Console.WriteLine("Q8: customer who has placed the highest number of orders during the current year.");

            foreach (var orderGroup in topCustomer)
            {
                Console.WriteLine($"CustoemrID: {orderGroup.CustoemrId}");
                Console.WriteLine($"Number of orders: {orderGroup.CurrentYearTotalOrders}");
            }

        }
    }
}
