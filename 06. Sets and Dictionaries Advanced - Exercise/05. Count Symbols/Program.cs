using System;
using System.Collections.Generic;

string input = Console.ReadLine();
SortedDictionary<char, int> counts = new SortedDictionary<char, int>();

foreach (char ch in input)
{
    if (!counts.ContainsKey(ch))
        counts[ch] = 0;
    counts[ch]++;
}

foreach (var pair in counts)
    Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
