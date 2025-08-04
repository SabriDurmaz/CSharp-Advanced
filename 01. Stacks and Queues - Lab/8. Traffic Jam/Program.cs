using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<string> queue = new Queue<string>();
        int totalCarsPassed = 0;
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            if (input == "green")
            {
                for (int i = 0; i < n && queue.Count > 0; i++)
                {
                    Console.WriteLine($"{queue.Dequeue()} passed!");
                    totalCarsPassed++;
                }
            }
            else
            {
                queue.Enqueue(input);
            }
        }

        Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
    }
}