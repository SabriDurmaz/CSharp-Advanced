using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());
string[] moves = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[,] field = new string[size, size];

int row = 0;
int col = 0;
int coals = 0;

for (int i = 0; i < size; i++)
{
    string[] line = Console.ReadLine().Split();
    for (int j = 0; j < size; j++)
    {
        field[i, j] = line[j];
        if (line[j] == "s") { row = i; col = j; }
        if (line[j] == "c") coals++;
    }
}

foreach (var move in moves)
{
    int newRow = row;
    int newCol = col;

    if (move == "up") newRow--;
    else if (move == "down") newRow++;
    else if (move == "left") newCol--;
    else if (move == "right") newCol++;

    if (newRow >= 0 && newRow < size && newCol >= 0 && newCol < size)
    {
        row = newRow;
        col = newCol;

        if (field[row, col] == "c")
        {
            coals--;
            field[row, col] = "*";
            if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({row}, {col})");
                return;
            }
        }
        else if (field[row, col] == "e")
        {
            Console.WriteLine($"Game over! ({row}, {col})");
            return;
        }
    }
}

Console.WriteLine($"{coals} coals left. ({row}, {col})");
