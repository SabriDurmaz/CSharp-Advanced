using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        for (int i = 0; i < args[1] && queue.Count > 0; i++)
            queue.Dequeue();

        Console.WriteLine(queue.Count == 0 ? "0" : queue.Contains(args[2]) ? "true" : queue.Min().ToString());
    }
}