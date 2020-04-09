using System;

namespace ProjectEuler.net_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Problem #1 Result is: " + Problem1.GetResult());
            Console.Beep();
            Console.Read();

            // Problem 2
            Problem2 problem2 = new Problem2();
            Console.WriteLine("Problem #2 Result is: " + problem2.GetResult());
            Console.Beep();
            Console.Read();

        }
    }
}
