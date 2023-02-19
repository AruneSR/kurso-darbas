using System;


namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite metodą, kuris pasisveikintų su vartotoju.
            // Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
            //  Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda formatuotai.

            Console.WriteLine("Įveskite savo varda:");
            string vardas = Console.ReadLine();
            
            Console.WriteLine("Įveskite savo amžių");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hobio pavadinimas");
            string pavadinimas = Console.ReadLine();
            PasisveikinimasPanaudojantVarda(vardas, amzius, pavadinimas);

        }

        

        internal static void PasisveikinimasPanaudojantVarda (string vardas, int amzius, string pavadinimas)
        {
            Console.WriteLine($"Labas,{vardas} {(amzius)}");
            Console.WriteLine($"Jūsų įrašytas hobis:{pavadinimas}");
        }
    }   
}
