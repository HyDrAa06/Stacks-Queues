using System;
using System.Text;

namespace SimpleTextEditor
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of commands:");
            int n=int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            Stack<string> stack = new Stack<string>(char.Parse(" "));
            //Stack<string> undo = new Stack<string>();

            Console.WriteLine("Commands:");
            for(int i = 0; i < n; i++)
            {
                string[] command=Console.ReadLine().Split(" ").ToArray();

                if (command[0] == "1")
                {
                    builder.Append(command[1]);
                    stack.Push(builder.ToString());
                }

                if(command[0] == "2")
                {
                    //remove ot do
                    builder.Remove(builder.Length - int.Parse(command[1]), int.Parse(command[1]));
                    stack.Push(builder.ToString());
                }
                if (command[0] == "3")
                {
                    Console.WriteLine(builder[int.Parse(command[1]) - 1]);
                }
                if (command[0] == "4")
                {
                    builder.Clear();
                    stack.Clear();
                    builder.Append(undo.Peek());
                }
            }
        }
    }
}