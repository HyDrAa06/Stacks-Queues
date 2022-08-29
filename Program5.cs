using System;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepared food:");
            int preparedFood=int.Parse(Console.ReadLine());

            Console.WriteLine("Orders:");
            int[]inputOrders = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();

            var orders = new Queue<int>(inputOrders);
            var leftOrders = new Queue<int>();

            foreach(var order in orders)
            {
                preparedFood=preparedFood-order;
                if (preparedFood < 0)
                {
                    leftOrders.Enqueue(order);
                }
            }

            Console.WriteLine("Biggest order: ");   
            Console.WriteLine(orders.Max());

            if(preparedFood==0 || preparedFood > 0)
            {
                Console.WriteLine("Orders compleate");
            }

            if (preparedFood < 0)
            {
                Console.WriteLine("Orders left: " + String.Join(" ", leftOrders));
            }          
            
        }
    }
}