using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, j];
            }
            Console.WriteLine(sum);
        }
    }
}