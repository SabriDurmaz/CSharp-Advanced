using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
    int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = line[j];
    }
}

string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (string bomb in bombs)
{
    int[] pos = bomb.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int row = pos[0];
    int col = pos[1];

    if (matrix[row, col] > 0)
    {
        int power = matrix[row, col];
        matrix[row, col] = 0;

        for (int i = row - 1; i <= row + 1; i++)
        {
            for (int j = col - 1; j <= col + 1; j++)
            {
                if (i >= 0 && i < size && j >= 0 && j < size && matrix[i, j] > 0)
                {
                    matrix[i, j] -= power;
                }
            }
        }
    }
}

int aliveCount = 0;
int aliveSum = 0;

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (matrix[i, j] > 0)
        {
            aliveCount++;
            aliveSum += matrix[i, j];
        }
    }
}

Console.WriteLine($"Alive cells: {aliveCount}");
Console.WriteLine($"Sum: {aliveSum}");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
