using System;

namespace BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string input = Console.ReadLine();

            bool output = true;
            var check = new Stack<char>();

            
            foreach (var c in input)
            {
                string b = "";
                if (c.ToString() =="{" || c.ToString()=="(" || c.ToString() =="[")
                {
                    check.Push(c);
                }
                else
                {
                    if (c.ToString() == "]")
                    {
                        b="[";
                    }
                    if(c.ToString() == ")")
                    {
                        b= "(";
                    }
                    if (c.ToString() == "}")
                    {
                        b = "{";
                    }

                    if(b != check.Peek().ToString())
                    {
                        output = false;
                    }
                    check.Pop();
                }
            }

            if (output == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
