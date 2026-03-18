using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCodeTemplate
{
    class Product
    {
        public int ProCode { get; set; }
        public string ProName { get; set; }
        public string ProCategory { get; set; }
        public double ProMrp { get; set; }

        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{ProCode=101, ProName="Rice", ProCategory="Grain", ProMrp=50},
                new Product{ProCode=102, ProName="Wheat", ProCategory="Grain", ProMrp=40},
                new Product{ProCode=103, ProName="Oil", ProCategory="FMCG", ProMrp=120},
                new Product{ProCode=104, ProName="Soap", ProCategory="FMCG", ProMrp=30},
                new Product{ProCode=105, ProName="Milk", ProCategory="Dairy", ProMrp=25}
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            var products = product.GetProducts();

            // 2. Write a LINQ query to search and display all products with category "Grain".
            Console.WriteLine("Question 2");
            var result2 = products.Where(p => p.ProCategory == "Grain");
            foreach (var item in result2)
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProCategory}\t{item.ProMrp}");

            // 3. Write a LINQ query to sort products in ascending order by product code.
            Console.WriteLine("\nQuestion 3");
            var result3 = products.OrderBy(p => p.ProCode);
            foreach (var item in result3)
                Console.WriteLine($"{item.ProCode}\t{item.ProName}");

            // 4. Write a LINQ query to sort products in ascending order by product Category.
            Console.WriteLine("\nQuestion 4");
            var result4 = products.OrderBy(p => p.ProCategory);
            foreach (var item in result4)
                Console.WriteLine($"{item.ProCategory}\t{item.ProName}");

            // 5. Write a LINQ query to sort products in ascending order by product Mrp.
            Console.WriteLine("\nQuestion 5");
            var result5 = products.OrderBy(p => p.ProMrp);
            foreach (var item in result5)
                Console.WriteLine($"{item.ProName}\t{item.ProMrp}");

            // 6. Write a LINQ query to sort products in descending order by product Mrp.
            Console.WriteLine("\nQuestion 6");
            var result6 = products.OrderByDescending(p => p.ProMrp);
            foreach (var item in result6)
                Console.WriteLine($"{item.ProName}\t{item.ProMrp}");

            // 7. Write a LINQ query to display products group by product Category.
            Console.WriteLine("\nQuestion 7");
            var result7 = products.GroupBy(p => p.ProCategory);
            foreach (var group in result7)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                    Console.WriteLine($"  {item.ProName}");
            }

            // 8. Write a LINQ query to display products group by product Mrp.
            Console.WriteLine("\nQuestion 8");
            var result8 = products.GroupBy(p => p.ProMrp);
            foreach (var group in result8)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                    Console.WriteLine($"  {item.ProName}");
            }

            // 9. Write a LINQ query to display product detail with highest price in FMCG category.
            Console.WriteLine("\nQuestion 9");
            var result9 = products
                          .Where(p => p.ProCategory == "FMCG")
                          .OrderByDescending(p => p.ProMrp)
                          .FirstOrDefault();
            Console.WriteLine($"{result9.ProName}\t{result9.ProMrp}");

            // 10. Write a LINQ query to display count of total products.
            Console.WriteLine("\nQuestion 10");
            var result10 = products.Count();
            Console.WriteLine($"Total Products: {result10}");

            // 11. Write a LINQ query to display count of total products with category FMCG.
            Console.WriteLine("\nQuestion 11");
            var result11 = products.Count(p => p.ProCategory == "FMCG");
            Console.WriteLine($"FMCG Count: {result11}");

            // 12. Write a LINQ query to display Max price.
            Console.WriteLine("\nQuestion 12");
            var result12 = products.Max(p => p.ProMrp);
            Console.WriteLine($"Max Price: {result12}");

            // 13. Write a LINQ query to display Min price.
            Console.WriteLine("\nQuestion 13");
            var result13 = products.Min(p => p.ProMrp);
            Console.WriteLine($"Min Price: {result13}");

            // 14. Write a LINQ query to display whether all products are below Mrp Rs.30 or not.
            Console.WriteLine("\nQuestion 14");
            var result14 = products.All(p => p.ProMrp < 30);
            Console.WriteLine($"All below 30: {result14}");

            // 15. Write a LINQ query to display whether any products are below Mrp Rs.30 or not.
            Console.WriteLine("\nQuestion 15");
            var result15 = products.Any(p => p.ProMrp < 30);
            Console.WriteLine($"Any below 30: {result15}");
        }
    }
}