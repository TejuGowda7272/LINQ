using ProductLINQFullExample;


        // Step 1: Create a list of products
        List<Product> products = new List<Product>
            {
                new Product(1, "Laptop", 75000, new DateTime(2024, 1, 10)),
                new Product(2, "Mobile", 25000, new DateTime(2025, 2, 5)),
                new Product(3, "Headphones", 3000, new DateTime(2023, 12, 15)),
                new Product(4, "Smartwatch", 5000, new DateTime(2024, 8, 20)),
                new Product(5, "Tablet", 20000, new DateTime(2024, 5, 12)),
                new Product(6, "Monitor", 15000, new DateTime(2024, 9, 3)),
                new Product(7, "Keyboard", 1500, new DateTime(2023, 11, 7)),
                new Product(8, "Mouse", 800, new DateTime(2024, 4, 1))
            };

        // ===== LINQ OPERATORS PRACTICE =====

        // 1. SELECT → Project specific properties
        var names = products.Select(p => p.Name);
        Console.WriteLine("All product names:");
        foreach (var name in names) Console.WriteLine(name);

        // 2. WHERE → Filter
        var expensive = products.Where(p => p.Price > 20000);
        Console.WriteLine("\nProducts with Price > 20000:");
        foreach (var p in expensive) Console.WriteLine($"{p.Name} - {p.Price}");

        // 3. ORDERBY → Ascending sort
        var orderedByPrice = products.OrderBy(p => p.Price);
        Console.WriteLine("\nProducts ordered by price:");
        foreach (var p in orderedByPrice) Console.WriteLine($"{p.Name} - {p.Price}");

        // 4. ORDERBYDESCENDING → Descending sort
        var orderedByPriceDesc = products.OrderByDescending(p => p.Price);
        Console.WriteLine("\nProducts ordered by price (desc):");
        foreach (var p in orderedByPriceDesc) Console.WriteLine($"{p.Name} - {p.Price}");

        // 5. THENBY → Multiple sorting levels
        var multiSort = products.OrderBy(p => p.Price).ThenBy(p => p.Name);
        Console.WriteLine("\nProducts sorted by price, then name:");
        foreach (var p in multiSort) Console.WriteLine($"{p.Name} - {p.Price}");

        // 6. FIRST / FIRSTORDEFAULT
        var firstProduct = products.First();
        Console.WriteLine($"\nFirst product: {firstProduct.Name}");
        var firstCheap = products.FirstOrDefault(p => p.Price < 1000);
        Console.WriteLine($"First cheap product: {(firstCheap != null ? firstCheap.Name : "None")}");

        // 7. LAST / LASTORDEFAULT
        var lastProduct = products.Last();
        Console.WriteLine($"\nLast product: {lastProduct.Name}");

        // 8. SINGLE / SINGLEORDEFAULT
        var singleProduct = products.SingleOrDefault(p => p.ID == 3);
        Console.WriteLine($"\nSingle product with ID=3: {singleProduct?.Name}");

        // 9. TAKE → First N elements
        var firstThree = products.Take(3);
        Console.WriteLine("\nFirst 3 products:");
        foreach (var p in firstThree) Console.WriteLine(p.Name);

        // 10. SKIP → Skip first N elements
        var skipThree = products.Skip(3);
        Console.WriteLine("\nProducts after skipping first 3:");
        foreach (var p in skipThree) Console.WriteLine(p.Name);

        // 11. ANY → Check if any matches
        bool anyExpensive = products.Any(p => p.Price > 80000);
        Console.WriteLine($"\nAny product price > 80000? {anyExpensive}");

        // 12. ALL → Check if all match condition
        bool allAbove500 = products.All(p => p.Price > 500);
        Console.WriteLine($"All products above ₹500? {allAbove500}");

        // 13. COUNT → Count matching items
        int cheapCount = products.Count(p => p.Price < 5000);
        Console.WriteLine($"\nProducts under ₹5000: {cheapCount}");

        // 14. SUM / AVG / MIN / MAX
        double totalPrice = products.Sum(p => p.Price);
        double avgPrice = products.Average(p => p.Price);
        double minPrice = products.Min(p => p.Price);
        double maxPrice = products.Max(p => p.Price);

        Console.WriteLine($"\nTotal Price: ₹{totalPrice}");
        Console.WriteLine($"Average Price: ₹{avgPrice}");
        Console.WriteLine($"Min Price: ₹{minPrice}");
        Console.WriteLine($"Max Price: ₹{maxPrice}");

        // 15. GROUPBY
        var groupByYear = products.GroupBy(p => p.ManufactureDate.Year);
        Console.WriteLine("\nProducts grouped by Manufacture Year:");
        foreach (var group in groupByYear)
        {
            Console.WriteLine($"Year: {group.Key}");
            foreach (var p in group) Console.WriteLine($"   {p.Name}");
        }

        // 16. DISTINCT
        var distinctYears = products.Select(p => p.ManufactureDate.Year).Distinct();
        Console.WriteLine("\nDistinct Manufacture Years:");
        foreach (var year in distinctYears) Console.WriteLine(year);

        // 17. REVERSE
        var reversed = products.AsEnumerable().Reverse();
        Console.WriteLine("\nProducts in reverse order:");
        foreach (var p in reversed) Console.WriteLine(p.Name);