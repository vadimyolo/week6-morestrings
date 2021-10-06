using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada eesnime
            //programm kusib kasutajal sisestada oma perekonnanime
            //programm loeb palju a tahte on tema nimes ja eprekonnanimes

            Console.WriteLine("Sisesta oma eesnime.");
            string firstName = Console.ReadLine();
            Console.WriteLine($"{firstName}, palun sisestage oma perekonnanime.");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();
            int counter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    counter++;
                }

            }



            if (counter  == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' täht.");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte.");
            }


            
        }
    }
}
