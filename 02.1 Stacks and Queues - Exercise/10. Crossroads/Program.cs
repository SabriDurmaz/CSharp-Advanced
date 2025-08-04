using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int green = int.Parse(Console.ReadLine());
        int window = int.Parse(Console.ReadLine());
        var cars = new Queue<string>();
        int passed = 0;

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            if (input == "green")
            {
                int time = green;
                while (time > 0 && cars.Count > 0)
                {
                    string car = cars.Peek();
                    if (car.Length <= time)
                    {
                        time -= car.Length;
                        passed++;
                        cars.Dequeue();
                    }
                    else
                    {
                        if (car.Length > time + window)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {car[time + window]}.");
                            return;
                        }
                        passed++;
                        cars.Dequeue();
                        time = 0;
                    }
                }
            }
            else
            {
                cars.Enqueue(input);
            }
        }

        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{passed} total cars passed the crossroads.");
    }
}