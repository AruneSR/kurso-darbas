using System;


namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Išveskite pasirinkto skaičiaus daugybos lentelę.

            int skaicius = 3;
          
            Console.WriteLine("{0} * {1} = {2}", skaicius, 0 , skaicius * 0);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 1, skaicius * 1);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 2, skaicius * 2);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 3, skaicius * 3);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 4, skaicius * 4);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 5, skaicius * 5);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 6, skaicius * 6);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 7, skaicius * 7);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 8, skaicius * 8);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 9, skaicius * 9);

            //Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme.
            //Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.

            int a = 25;
            Console.WriteLine("{1} * {1} = {2}", 5, 5, a);
        }

    }
}
