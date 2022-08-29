using System;

namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");

            int[]command = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();

            Console.WriteLine("2nd input:");

            int[] input = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            if (command[0] != input.Length)
            {
                throw new ArgumentException("Invalid input");
            }

            var queue = new Queue<int>(input);

            for (int i = 0; i < command[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(command[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
