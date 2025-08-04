using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int food = int.Parse(Console.ReadLine());
        var orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        Console.WriteLine(orders.Max());

        while (orders.Count > 0 && food >= orders.Peek())
            food -= orders.Dequeue();

        Console.WriteLine(orders.Count == 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");
    }
}