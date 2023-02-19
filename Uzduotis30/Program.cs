using System;


namespace Uzduotis30
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //  Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  Sukurkite ir panaudokite šiuos metodus:
            //  Suma;
            //   Skirtumas;
            //  Sandauga;
            //   Dalmuo;

            Console.WriteLine("Įveskite du sveikuosius skaičius");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, skaicius1 + skaicius2);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skaicius1 - skaicius2);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skaicius1 * skaicius2);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, skaicius1 / skaicius2);
        } 
    }

    internal class Calculator
    {
        internal static int Sum(int skaicius1, int skaicius2)
        {
            throw new NotImplementedException();
        }
    }
}
