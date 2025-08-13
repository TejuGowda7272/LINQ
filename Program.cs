using System;
using System.Collections.Generic;
using System.Linq;
using ProductLinqDemo;

            List<Product> products = new List<Product>();

            Console.WriteLine("Enter details for 2 products:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nProduct {i + 1}:");
                Product p = new Product();

                Console.Write("Enter ID: ");
                p.ID = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                p.Name = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.Price = double.Parse(Console.ReadLine());

                Console.Write("Enter Manufacture Date (yyyy-MM-dd): ");
                p.ManufactureDate = DateTime.Parse(Console.ReadLine());

                products.Add(p);
            }

            Console.WriteLine("\n===== LINQ Operations =====");

            // 1. Select all product names
            var names = products.Select(p => p.Name);
            Console.WriteLine("\nProduct Names:");
            foreach (var n in names) Console.WriteLine(n);

            // 2. Filter products with price > 500
            var expensive = products.Where(p => p.Price > 500);
            Console.WriteLine("\nProducts with Price > 500:");
            foreach (var p in expensive) p.Display();

            // 3. Order by Price
            var sortedByPrice = products.OrderBy(p => p.Price);
            Console.WriteLine("\nProducts Sorted by Price:");
            foreach (var p in sortedByPrice) p.Display();

            // 4. Order by Price descending
            var sortedDesc = products.OrderByDescending(p => p.Price);
            Console.WriteLine("\nProducts Sorted by Price (Descending):");
            foreach (var p in sortedDesc) p.Display();

            // 5. First product
            var firstProduct = products.First();
            Console.WriteLine("\nFirst Product:");
            firstProduct.Display();

            // 6. Last product
            var lastProduct = products.Last();
            Console.WriteLine("\nLast Product:");
            lastProduct.Display();

            // 7. Count products
            Console.WriteLine($"\nTotal Products: {products.Count()}");

            // 8. Max price
            var maxPrice = products.Max(p => p.Price);
            Console.WriteLine($"\nMax Price: {maxPrice}");

            // 9. Min price
            var minPrice = products.Min(p => p.Price);
            Console.WriteLine($"Min Price: {minPrice}");

            // 10. Average price
            var avgPrice = products.Average(p => p.Price);
            Console.WriteLine($"Average Price: {avgPrice}");

            // 11. Group by Manufacture Year
            var groupByYear = products.GroupBy(p => p.ManufactureDate.Year);
            Console.WriteLine("\nProducts Grouped by Manufacture Year:");
            foreach (var group in groupByYear)
            {
                Console.WriteLine($"Year: {group.Key}");
                foreach (var p in group) p.Display();
            }

            // 12. Check if any product costs above 1000
            bool anyExpensive = products.Any(p => p.Price > 1000);
            Console.WriteLine($"\nAny product above 1000? {anyExpensive}");

            // 13. All products above 100
            bool allAbove100 = products.All(p => p.Price > 100);
            Console.WriteLine($"All products above 100? {allAbove100}");

            // 14. Take first 3 products
            var firstThree = products.Take(3);
            Console.WriteLine("\nFirst 3 Products:");
            foreach (var p in firstThree) p.Display();

            // 15. Skip first 2 products
            var skipTwo = products.Skip(2);
            Console.WriteLine("\nProducts after skipping first 2:");
            foreach (var p in skipTwo) p.Display();
        