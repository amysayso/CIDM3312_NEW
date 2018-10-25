using System;

namespace nickname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is what you typed in: ");
            for(int i = 0; i < args.Length; i++)
            { 
                //Console.WriteLine("Did i get here?");
                Console.WriteLine($"{args[i]}");
            }

        }
    }
}
