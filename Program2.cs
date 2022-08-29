using System;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            int[] command=Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            

            Console.WriteLine("2nd input: ");
            int[] input= Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            if (command[0] != input.Length)
            {
                throw new ArgumentException("Invalid input");
            }

            var stack = new Stack<int>(input);

            for (int i = 0; i < command[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(command[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
            
            
        }
    }
}
