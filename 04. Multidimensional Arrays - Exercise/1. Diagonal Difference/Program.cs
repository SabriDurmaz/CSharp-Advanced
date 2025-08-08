using System;
using System.Linq;

int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = nums[j];
    }
}

int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < n; i++)
{
    sum1 += matrix[i, i];
    sum2 += matrix[i, n - i - 1];
}

Console.WriteLine(Math.Abs(sum1 - sum2));
