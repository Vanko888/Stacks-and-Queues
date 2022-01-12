using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> firstInput = new Stack<string>(Console.ReadLine().Split());
            Stack<string> secondInput = new Stack<string>();
            int sum = 0;
            while (firstInput.Count > 0)
            {
                secondInput.Push(firstInput.Peek());
                firstInput.Pop();
            }
            sum += int.Parse(secondInput.Peek());
            secondInput.Pop();
            while (secondInput.Count > 0)
            {
                if (secondInput.Peek() == "+")
                {
                    secondInput.Pop();
                    sum += int.Parse(secondInput.Peek());
                    secondInput.Pop();
                }
                else
                {
                    secondInput.Pop();
                    sum -= int.Parse(secondInput.Peek());
                    secondInput.Pop();
                }
            }
            Console.WriteLine(sum);
        }
    }
}
