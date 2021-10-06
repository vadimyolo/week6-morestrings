using System;

namespace AnotherStringsToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun kirjuta Hello World.");
            string helloWorld = Console.ReadLine();

            for (int i = helloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(helloWorld[i]);
            }
        }
    }
}
