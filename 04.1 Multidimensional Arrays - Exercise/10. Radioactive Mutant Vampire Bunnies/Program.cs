using System;
using System.Linq;

int[] dims = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = dims[0], cols = dims[1];
char[,] matrix = new char[rows, cols];

int playerRow = 0, playerCol = 0;

for (int i = 0; i < rows; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = line[j];
        if (matrix[i, j] == 'P')
        {
            playerRow = i;
            playerCol = j;
            matrix[i, j] = '.';
        }
    }
}

char[] moves = Console.ReadLine().ToCharArray();

foreach (char move in moves)
{
    int prevRow = playerRow;
    int prevCol = playerCol;

    if (move == 'U') playerRow--;
    else if (move == 'D') playerRow++;
    else if (move == 'L') playerCol--;
    else if (move == 'R') playerCol++;

    char[,] nextMatrix = Spread(matrix, rows, cols);

    if (!InBounds(playerRow, playerCol, rows, cols))
    {
        Print(nextMatrix, rows, cols);
        Console.WriteLine($"won: {prevRow} {prevCol}");
        break;
    }

    if (nextMatrix[playerRow, playerCol] == 'B')
    {
        Print(nextMatrix, rows, cols);
        Console.WriteLine($"dead: {playerRow} {playerCol}");
        break;
    }

    matrix = nextMatrix;
}

static char[,] Spread(char[,] m, int r, int c)
{
    char[,] result = new char[r, c];
    Array.Copy(m, result, m.Length);

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (m[i, j] != 'B') continue;
            if (i > 0) result[i - 1, j] = 'B';
            if (i < r - 1) result[i + 1, j] = 'B';
            if (j > 0) result[i, j - 1] = 'B';
            if (j < c - 1) result[i, j + 1] = 'B';
        }
    }
    return result;
}

static bool InBounds(int row, int col, int r, int c) =>
    row >= 0 && row < r && col >= 0 && col < c;

static void Print(char[,] m, int r, int c)
{
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
            Console.Write(m[i, j]);
        Console.WriteLine();
    }
}
