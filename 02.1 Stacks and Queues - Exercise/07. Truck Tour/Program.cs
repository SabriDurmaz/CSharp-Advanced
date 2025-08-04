using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var queue = new Queue<(int fuel, int distance)>();

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            queue.Enqueue((input[0], input[1]));
        }

        for (int start = 0; start < n; start++)
        {
            int fuel = 0;
            bool success = true;

            foreach (var pump in queue)
            {
                fuel += pump.fuel - pump.distance;
                if (fuel < 0)
                {
                    success = false;
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine(start);
                return;
            }

            queue.Enqueue(queue.Dequeue());
        }
    }
}