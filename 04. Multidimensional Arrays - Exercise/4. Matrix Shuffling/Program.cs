using System;
using System.Linq;

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];
int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = line[j];
    }
}

string input;

while ((input = Console.ReadLine()) != "END")
{
    string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (parts.Length == 5 && parts[0] == "swap")
    {
        int r1 = int.Parse(parts[1]);
        int c1 = int.Parse(parts[2]);
        int r2 = int.Parse(parts[3]);
        int c2 = int.Parse(parts[4]);

        if (r1 >= 0 && r1 < rows && c1 >= 0 && c1 < cols && r2 >= 0 && r2 < rows && c2 >= 0 && c2 < cols)
        {
            int temp = matrix[r1, c1];
            matrix[r1, c1] = matrix[r2, c2];
            matrix[r2, c2] = temp;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
