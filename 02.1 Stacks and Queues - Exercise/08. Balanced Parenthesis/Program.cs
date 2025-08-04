using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char> { { '}', '{' }, { ']', '[' }, { ')', '(' } };
        bool valid = true;

        foreach (char c in input)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else if (stack.Count == 0 || stack.Pop() != pairs[c])
            {
                valid = false;
                break;
            }
        }

        Console.WriteLine(valid && stack.Count == 0 ? "YES" : "NO");
    }
}