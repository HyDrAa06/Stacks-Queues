using System;

namespace MaxAndMinElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of commands:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input:");

            var stack = new Stack<int>();

            List<int> temp = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                if (command[0] == 2 && stack.Count>0)
                {
                    stack.Pop();
                }
                if(command[0] == 3)
                {
                    temp.Add(stack.Max());
                }
                if (command[0] == 4)
                {
                    temp.Add(stack.Min());
                }
            }

            Console.WriteLine("Result");
            for(int i = 0; i <temp.Count; i++)
            {
                Console.WriteLine(temp[i]);
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}