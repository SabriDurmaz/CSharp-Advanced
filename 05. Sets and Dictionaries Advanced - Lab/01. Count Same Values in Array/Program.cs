using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Dictionary<double, int> counts = new Dictionary<double, int>();

        foreach (var number in numbers)
        {
            if (!counts.ContainsKey(number))
            {
                counts[number] = 0;
            }
            counts[number]++;
        }

        foreach (var kvp in counts)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }
    }
}