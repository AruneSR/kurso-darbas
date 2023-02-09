using System;
using System.Text;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* 1 punktas:
             * 
             * Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.*/

            Console.WriteLine("Labas Arūne");


            /* 2 punktas:
             * 
             * Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su šiuo amžiumi:
             * “Įvestas amžius: {amžius}”.
             * Tarp {} nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta.*/

            int amžius = 30;
            Console.WriteLine("Įvestas amžius:{0}", amžius);

            /* 3punktas:
             * 
             * Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje
             * be tarpų tarp šių skaičių (skaičius - 25, išvedimas - 2525252525).*/


            int skaičius = 25;

            Console.Write("{0}", skaičius);
            Console.Write("{0}", skaičius);
            Console.Write("{0}", skaičius);
            Console.Write("{0}", skaičius);
            Console.Write("{0}", skaičius);

            /* Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje su tarpais
             * tarp šių skaičių (skaičius - 25, rezultatas - 25 25 25 25 25). */

            var x = 25;

            Console.WriteLine();
            Console.Write("{0} ", x);
            Console.Write("{0} ", x);
            Console.Write("{0} ", x);
            Console.Write("{0} ", x);
            Console.Write("{0} ", x);


        }
    }
}
