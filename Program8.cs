using System;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Songs: ");
            string[] inputSongs = Console.ReadLine().Split(", ").ToArray();
            var songs = new Queue<string>(inputSongs);

            while(true)
            {
                Console.WriteLine("Command:");
                List<string> command=Console.ReadLine().Split(" ").ToList();

                if (command[0] == "Play")
                {
                    songs.Dequeue();    
                }

                if(command[0] == "Add")
                {
                    command.RemoveAt(0);
                    string song =string.Join(" ", command);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained.");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }

                if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                if (songs.Count() == 0)
                {
                    break;
                }
            }

            Console.WriteLine("No more songs!");

        }
    }
}