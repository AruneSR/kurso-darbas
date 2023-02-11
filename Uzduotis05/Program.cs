using Microsoft.Win32;
using System;


namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
           // kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes.

            int a = 3;
            int b = 6;
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

       
            double dalyba =(double) a / b;

            Console.WriteLine("{0} / {1} = {2}", a, b, dalyba);
            Console.WriteLine();

            //Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu

            Console.WriteLine(Math.Sqrt(3));
            Console.WriteLine(Math.Pow(3, 3));
            Console.WriteLine();

            //Išveskite į ekraną trijų skaičių sandaugą.


            int d = 9;
            Console.WriteLine("{0} * {1} * {2}", a, b, d);
            Console.WriteLine();
            // Išveskite į ekraną šių veiksmų atsakymus:
            // -1 + 4 * 6 = 23
            // 14 + -4 * 6 / 11 = 12
            // 2 + 15 / 6 * 1 - 7 % 2 = 3 */

            int sudėtisdaugyba = -1 + 4 * 6;
            Console.WriteLine(-1 + 4 * 6);
            int skaiciai = 14 + (-4 * 6) / 11;
            Console.WriteLine(14 + (-4 * 6) / 11);
            int liekana = 2 + (15 / 6 * 1) - 7 % 2;
            Console.WriteLine(2 + (15 / 6 * 1) - 7 % 2);
            }

    }
}
