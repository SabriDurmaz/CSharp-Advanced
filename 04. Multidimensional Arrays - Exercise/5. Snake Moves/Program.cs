using System;
using System.Collections.Generic;
using System.Linq;

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string snake = Console.ReadLine();
int rows = size[0];
int cols = size[1];

Queue<char> queue = new Queue<char>(snake);
char[,] matrix = new char[rows, cols];

for (int i = 0; i < rows; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 0; j < cols; j++)
        {
            char ch = queue.Dequeue();
            matrix[i, j] = ch;
            queue.Enqueue(ch);
        }
    }
    else
    {
        for (int j = cols - 1; j >= 0; j--)
        {
            char ch = queue.Dequeue();
            matrix[i, j] = ch;
            queue.Enqueue(ch);
        }
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
