using System;
using System.Collections.Generic;
using System.Linq;

int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int a = sizes[0], b = sizes[1];

HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();

for (int i = 0; i < a; i++)
    first.Add(int.Parse(Console.ReadLine()));

for (int i = 0; i < b; i++)
    second.Add(int.Parse(Console.ReadLine()));

first.IntersectWith(second);
Console.WriteLine(string.Join(" ", first));
