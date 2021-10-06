using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajalt sisestada ees- ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale.

            Console.WriteLine("Sisesta oma eesnimi.");

            string firstName = Console.ReadLine();
           

            Console.WriteLine("Sisesta oma perekonnanimi.");


            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere! {firstName[0]}. {lastName[0]}.");
           

            
        }
    }
}
