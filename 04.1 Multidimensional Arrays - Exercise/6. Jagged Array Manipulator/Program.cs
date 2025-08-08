using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int i = 0; i < rows; i++)
{
    matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
}

for (int i = 1; i < rows; i++)
{
    if (matrix[i].Length == matrix[i - 1].Length)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] *= 2;
            matrix[i - 1][j] *= 2;
        }
    }
    else
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] /= 2;
        }
        for (int j = 0; j < matrix[i - 1].Length; j++)
        {
            matrix[i - 1][j] /= 2;
        }
    }
}

string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = parts[0];
    int r = int.Parse(parts[1]);
    int c = int.Parse(parts[2]);
    int value = int.Parse(parts[3]);

    if (r >= 0 && r < rows && c >= 0 && c < matrix[r].Length)
    {
        if (command == "Add")
        {
            matrix[r][c] += value;
        }
        else if (command == "Subtract")
        {
            matrix[r][c] -= value;
        }
    }
}

for (int i = 0; i < rows; i++)
{
    Console.WriteLine(string.Join(" ", matrix[i]));
}
