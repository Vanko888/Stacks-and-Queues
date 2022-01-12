using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int carsCount = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    if (cars.Count >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsCount++;
                        }
                    }
                    else
                    {
                        int count = cars.Count;
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{carsCount} cars passed the crossroads.");

        }
    }
}
