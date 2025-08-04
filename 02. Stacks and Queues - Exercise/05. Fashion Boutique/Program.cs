using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        int capacity = int.Parse(Console.ReadLine());
        int racks = 1, current = 0;

        while (clothes.Count > 0)
        {
            if (current + clothes.Peek() <= capacity)
            {
                current += clothes.Pop();
            }
            else
            {
                racks++;
                current = 0;
            }
        }

        Console.WriteLine(racks);
    }
}