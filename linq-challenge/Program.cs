namespace linq_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product(1, "Wireless Mouse", "Electronics", 25.99m, 50),
                new Product(2, "Mechanical Keyboard", "Electronics", 79.99m, 25),
                new Product(3, "USB-C Cable", "Accessories", 12.50m, 100),
                new Product(4, "Laptop Stand", "Accessories", 34.99m, 30),
                new Product(5, "Water Bottle", "Home & Kitchen", 18.75m, 45),
                new Product(6, "Notebook", "Stationery", 6.99m, 80),
                new Product(7, "Desk Lamp", "Home & Kitchen", 42.50m, 20)
            };

            /*
             * Q5:
                Find the 3 most expensive products that are currently in stock.
                A product is considered in stock when: Stock > 0
                Return the product name and price.
            */

            var topThreeExpensiveProducts =
                products
                .Where(p => p.Stock > 0)
                .OrderBy(p => p.Price)
                .Take(3)
                .ToList();

            Console.WriteLine("Q5: the 3 most expensive products that are currently in stock:");

            foreach (var product in topThreeExpensiveProducts)
            {
                Console.WriteLine($"Product Name: {product.Name}");
                Console.WriteLine($"Product Price: {product.Price}");
            }

        }
    }
}
