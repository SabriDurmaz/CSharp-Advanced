using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        for (int i = 0; i < args[1] && stack.Count > 0; i++)
            stack.Pop();

        Console.WriteLine(stack.Count == 0 ? "0" : stack.Contains(args[2]) ? "true" : stack.Min().ToString());
    }
}