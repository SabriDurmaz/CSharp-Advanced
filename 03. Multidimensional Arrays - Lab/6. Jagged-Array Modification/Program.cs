using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] parts = command.Split();
            string action = parts[0];
            int row = int.Parse(parts[1]);
            int col = int.Parse(parts[2]);
            int value = int.Parse(parts[3]);

            if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            if (action == "Add")
            {
                jaggedArray[row][col] += value;
            }
            else if (action == "Subtract")
            {
                jaggedArray[row][col] -= value;
            }
        }

        foreach (var row in jaggedArray)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}