using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
HashSet<string> elements = new HashSet<string>();

for (int i = 0; i < n; i++)
    foreach (var el in Console.ReadLine().Split())
        elements.Add(el);

Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
