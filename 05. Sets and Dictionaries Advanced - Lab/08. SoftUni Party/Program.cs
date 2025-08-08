using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> vipGuests = new HashSet<string>();
        HashSet<string> regularGuests = new HashSet<string>();
        string input;

        while ((input = Console.ReadLine()) != "PARTY")
        {
            if (char.IsDigit(input[0]))
            {
                vipGuests.Add(input);
            }
            else
            {
                regularGuests.Add(input);
            }
        }

        while ((input = Console.ReadLine()) != "END")
        {
            if (vipGuests.Contains(input))
            {
                vipGuests.Remove(input);
            }
            else if (regularGuests.Contains(input))
            {
                regularGuests.Remove(input);
            }
        }

        Console.WriteLine(vipGuests.Count + regularGuests.Count);
        foreach (var guest in vipGuests)
        {
            Console.WriteLine(guest);
        }
        foreach (var guest in regularGuests)
        {
            Console.WriteLine(guest);
        }
    }
}