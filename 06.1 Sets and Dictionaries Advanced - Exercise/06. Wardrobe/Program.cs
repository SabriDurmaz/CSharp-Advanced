using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
var wardrobes = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    var parts = Console.ReadLine().Split(" -> ");
    var color = parts[0];
    var clothes = parts[1].Split(',');

    if (!wardrobes.ContainsKey(color))
        wardrobes[color] = new Dictionary<string, int>();

    foreach (var item in clothes)
    {
        if (!wardrobes[color].ContainsKey(item))
            wardrobes[color][item] = 0;
        wardrobes[color][item]++;
    }
}

var search = Console.ReadLine().Split();
var searchColor = search[0];
var searchItem = search[1];

foreach (var (color, items) in wardrobes)
{
    Console.WriteLine($"{color} clothes:");
    foreach (var (item, count) in items)
    {
        string found = color == searchColor && item == searchItem ? " (found!)" : "";
        Console.WriteLine($"* {item} - {count}{found}");
    }
}
