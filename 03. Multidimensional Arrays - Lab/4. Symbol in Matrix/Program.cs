using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];

        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        char symbol = char.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == symbol)
                {
                    Console.WriteLine($"({i}, {j})");
                    found = true;
                    return;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}