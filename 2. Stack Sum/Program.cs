using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();
            int sum = 0;
            Stack<int> nums = new Stack<int>(numbers);
            while (command != "end")
            {
                var currCommand = command.Split();
                if (currCommand[0] == "add")
                {
                    int num1 = int.Parse(currCommand[1]);
                    int num2 = int.Parse(currCommand[2]);
                    nums.Push(num1);
                    nums.Push(num2);
                }
                else
                {
                    if (nums.Count >= int.Parse(currCommand[1]))
                    {
                        for (int i = 0; i < int.Parse(currCommand[1]); i++)
                        {
                            nums.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            while(nums.Count > 0)
            {
                sum += nums.Peek();
                nums.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
