using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var stack = new Stack<int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var cmd = Console.ReadLine().Split();
            switch (cmd[0])
            {
                case "1": stack.Push(int.Parse(cmd[1])); break;
                case "2": if (stack.Count > 0) stack.Pop(); break;
                case "3": if (stack.Count > 0) Console.WriteLine(stack.Max()); break;
                case "4": if (stack.Count > 0) Console.WriteLine(stack.Min()); break;
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}