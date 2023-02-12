using System;
using System.Runtime.InteropServices;

namespace Uzduotis_07
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Liepkite vartotojui įvesti savo vardą ir amžių.
            // Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.”


            Console.WriteLine("Jūsų vardas");
            string vardas = Console.ReadLine();
            Console.WriteLine("o amzius");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jūsų vardas {0}, o amzius {1}.", vardas, skaicius);
            Console.WriteLine();

            // Liepkite vartotojui įvesti bet kokį simbolį.
            // Atspausdinkite 3x3 kvadratą iš to simbolio. 

            Console.WriteLine("Įveskite bet koki simboli");
            char simbolis = Convert.ToChar(Console.ReadLine());

            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.

            Console.WriteLine("Įveskite bet kokį skaičių");
            int x = Convert.ToInt32(Console.ReadLine());


            //Liepkite vartotojui įvesti tris skaičius. Išveskite visų šių skaičių sumą

            Console.WriteLine("Įveskite pirmą skaičių");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių");
            int trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3}", pirmas, antras, trecias, pirmas + antras + trecias);
            








        }
    }
}
