using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> parkingLot = new HashSet<string>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(", ");
            string direction = parts[0];
            string carNumber = parts[1];

            if (direction == "IN")
            {
                parkingLot.Add(carNumber);
            }
            else if (direction == "OUT")
            {
                parkingLot.Remove(carNumber);
            }
        }

        if (parkingLot.Count > 0)
        {
            foreach (var car in parkingLot)
            {
                Console.WriteLine(car);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}