using System;
using System.Linq;

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];
int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = nums[j];
    }
}

int maxSum = int.MinValue;
int startRow = 0;
int startCol = 0;

for (int i = 0; i < rows - 2; i++)
{
    for (int j = 0; j < cols - 2; j++)
    {
        int sum = 0;
        for (int r = i; r < i + 3; r++)
        {
            for (int c = j; c < j + 3; c++)
            {
                sum += matrix[r, c];
            }
        }

        if (sum > maxSum)
        {
            maxSum = sum;
            startRow = i;
            startCol = j;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

for (int i = startRow; i < startRow + 3; i++)
{
    for (int j = startCol; j < startCol + 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
