using System;
using System.Threading;

namespace ThreadYeeting
{
    class Program
    {
        static char output = '*';
        static void Main(string[] args)
        {
            Thread write = new Thread(Print);

            Thread read = new Thread(Read);
            write.Start();
            read.Start();

        }

        static void Print()
        {
            while (true)
            {
                Console.Write(output);
                Thread.Sleep(50);
            }
        }
        static void Read()
        {
            char tempChar = '*';
            while (true)
            {

                tempChar = Console.ReadKey().KeyChar;

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    output = tempChar;
                    Console.WriteLine();
                }

            }
        }
    }
}







