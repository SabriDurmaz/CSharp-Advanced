using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                stack.Push(i);
            }
            else if (expression[i] == ')')
            {
                int startIndex = stack.Pop();
                string subExpression = expression.Substring(startIndex, i - startIndex + 1);
                Console.WriteLine(subExpression);
            }
        }
    }
}