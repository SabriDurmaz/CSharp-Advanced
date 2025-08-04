using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int barrelSize = int.Parse(Console.ReadLine());
        var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        int intelligence = int.Parse(Console.ReadLine());
        int shots = 0, cost = 0;

        while (bullets.Count > 0 && locks.Count > 0)
        {
            int bullet = bullets.Pop();
            int currentLock = locks.Peek();
            shots++;
            cost += bulletPrice;

            if (bullet <= currentLock)
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (shots % barrelSize == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
            }
        }

        Console.WriteLine(locks.Count == 0
            ? $"{bullets.Count} bullets left. Earned ${intelligence - cost}"
            : $"Couldn't get through. Locks left: {locks.Count}");
    }
}