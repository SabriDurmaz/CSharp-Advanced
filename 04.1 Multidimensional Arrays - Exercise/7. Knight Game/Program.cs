using System;

int size = int.Parse(Console.ReadLine());
char[,] board = new char[size, size];

for (int i = 0; i < size; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < size; j++)
    {
        board[i, j] = line[j];
    }
}

int removed = 0;

while (true)
{
    int maxKills = 0;
    int targetRow = 0;
    int targetCol = 0;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            int kills = CountKills(board, i, j, size);
            if (kills > maxKills)
            {
                maxKills = kills;
                targetRow = i;
                targetCol = j;
            }
        }
    }

    if (maxKills == 0)
    {
        Console.WriteLine(removed);
        break;
    }

    board[targetRow, targetCol] = '0';
    removed++;
}

static int CountKills(char[,] board, int row, int col, int size)
{
    if (board[row, col] != 'K') return 0;

    int kills = 0;
    int[,] moves = new int[,]
    {
        {-2, -1}, {-2, 1}, {-1, 2}, {1, 2},
        {2, 1}, {2, -1}, {1, -2}, {-1, -2}
    };

    for (int i = 0; i < moves.GetLength(0); i++)
    {
        int newRow = row + moves[i, 0];
        int newCol = col + moves[i, 1];

        if (newRow >= 0 && newRow < size && newCol >= 0 && newCol < size)
        {
            if (board[newRow, newCol] == 'K')
            {
                kills++;
            }
        }
    }

    return kills;
}
