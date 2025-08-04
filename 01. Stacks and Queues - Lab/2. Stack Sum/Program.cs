using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>(numbers);

        string command;
        while ((command = Console.ReadLine().ToLower()) != "end")
        {
            string[] parts = command.Split();
            if (parts[0] == "add")
            {
                stack.Push(int.Parse(parts[1]));
                stack.Push(int.Parse(parts[2]));
            }
            else if (parts[0] == "remove")
            {
                int count = int.Parse(parts[1]);
                if (stack.Count >= count)
                {
                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
            }
        }

        Console.WriteLine($"Sum: {stack.Sum()}");
    }
}