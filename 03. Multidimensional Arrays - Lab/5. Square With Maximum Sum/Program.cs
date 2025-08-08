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
            int[] row = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
        Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
        Console.WriteLine(maxSum);
    }
}