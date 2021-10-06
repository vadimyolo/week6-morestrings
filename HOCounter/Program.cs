using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o', ja 'l' tahte on lauses hello world.
            Console.WriteLine("Sisesta Hello world.");
            string helloW = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'h')
                {
                    counter++;
                }
                if (helloW[i] == 'o')
                {
                    counter++;
                }
                if (helloW[i] == 'l')
                {
                    counter++;
                }
                Console.WriteLine($"Seal sonas on {counter} tahti");
            }
            



        }
    }
}
