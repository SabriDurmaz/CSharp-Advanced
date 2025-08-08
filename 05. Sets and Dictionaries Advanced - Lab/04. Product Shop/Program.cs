using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var shops = new SortedDictionary<string, Dictionary<string, double>>();
        string input;

        while ((input = Console.ReadLine()) != "Revision")
        {
            string[] parts = input.Split(", ");
            string shop = parts[0];
            string product = parts[1];
            double price = double.Parse(parts[2]);

            if (!shops.ContainsKey(shop))
            {
                shops[shop] = new Dictionary<string, double>();
            }
            shops[shop][product] = price;
        }

        foreach (var shop in shops)
        {
            Console.WriteLine($"{shop.Key}->");
            foreach (var product in shop.Value)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}