using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        int wasted = 0;

        while (cups.Count > 0 && bottles.Count > 0)
        {
            int cup = cups.Peek();
            while (cup > 0 && bottles.Count > 0)
            {
                cup -= bottles.Pop();
                if (cup <= 0)
                {
                    wasted += Math.Abs(cup);
                    cups.Dequeue();
                }
            }
        }

        Console.WriteLine(cups.Count == 0
            ? $"Bottles: {string.Join(" ", bottles)}"
            : $"Cups: {string.Join(" ", cups)}");
        Console.WriteLine($"Wasted litters of water: {wasted}");
    }
}