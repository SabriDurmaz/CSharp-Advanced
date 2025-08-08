using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var topThree = numbers.OrderByDescending(n => n).Take(3);

        Console.WriteLine(string.Join(" ", topThree));
    }
}