using System;

namespace FashionBotique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clothes:");
            int[]inputClotehs=Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();

            if(inputClotehs.Length > 50)
            {
                throw new ArgumentException("Invalid input");
            }

            for(int i = 0; i < inputClotehs.Length; i++)
            {
                if(inputClotehs[i] <0 || inputClotehs[i] > 20)
                {
                    throw new ArgumentException("Invalid input");
                }
            }

            var clothes = new Stack<int>(inputClotehs);

            Console.WriteLine("Capacity of racks: ");
            int rackCapacity = int.Parse(Console.ReadLine());

            if(rackCapacity > 20 || rackCapacity < 0)
            {
                throw new ArgumentException("Ivalid input");
            }

            for (int i = 0; i < inputClotehs.Length; i++)
            {
                if (inputClotehs[i] > rackCapacity)
                {
                    throw new ArgumentException("Invalid input");
                }
            }

            int rackAmount = 1;
            int temp=0;

            foreach(var cloth in clothes)
            {
                if (temp < rackCapacity)
                {
                    temp= temp+ cloth;
                    
                }
                if(temp == rackCapacity)
                {
                    rackAmount++;
                    temp = 0;                    
                }
                if(temp > rackCapacity)
                {
                    rackAmount++;
                    temp = cloth;
                }
            }
            
            Console.WriteLine("Racks needed: {0}",rackAmount);

        }
    }
}