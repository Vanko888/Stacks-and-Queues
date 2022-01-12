using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Queue<int>((Console.ReadLine().Split().Select(int.Parse)));
            while (numbers.Count > 0)
            {
                if (numbers.Peek() % 2 == 0)
                {
                    Console.Write(numbers.Peek());
                    if (numbers.Count > 1)
                    {
                        Console.Write(", ");
                    }
                    numbers.Dequeue();
                }
                else
                {
                    numbers.Dequeue();
                }
            }
        }
    }
}
