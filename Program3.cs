using System;
using System.Runtime.CompilerServices;

namespace CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cups:");
            int[]cupsInput=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var cups=new Queue<int>(cupsInput);

            Console.WriteLine("Bottles:");
            int[] bottlesInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var bottles= new Stack<int>(bottlesInput);

            int wastedWater = 0;

            int cup = cups.Peek();
            int bottle = bottles.Peek();

            while (true)
            {

                if (cup > bottle)
                {
                    cup = cup - bottle;
                    bottles.Pop();
                    bottle = bottles.Peek();                                        
                }

                else
                {
                    wastedWater = wastedWater + (bottle - cup);
                    bottles.Pop();
                    cups.Dequeue();

                    if (bottles.Count != 0)
                    {
                        bottle = bottles.Peek();
                    }

                    if (cups.Count != 0)
                    {
                        cup = cups.Peek();
                    }
                }


                if (bottles.Count == 0)
                {
                    Console.WriteLine("Cups: {0}", string.Join(" ", cups));
                    break;
                }
                if (cups.Count == 0)
                {
                    Console.WriteLine("Bottles: {0}", string.Join(" ", bottles));
                    break;
                }

            }

            Console.WriteLine("Wasted liters of water: {0}", wastedWater);

        }
    }
}