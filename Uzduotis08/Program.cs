using System;


namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        { //Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.

            Console.WriteLine("Įveskite sveikajį skaičių");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0} * {1} = {2}", skaicius, 1, skaicius * 1);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 2, skaicius * 2);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 3, skaicius * 3);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 4, skaicius * 4);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 5, skaicius * 5);

            // galvoju, kad galima būtų ir su šia formule, bet nesugalvojau kaip aprašyti komandą.
            //skaicius *= 1;
            //skaicius *= 2;
            //skaicius *= 3;
            //skaicius *= 4;
            //skaicius *= 5;

            // Liepkite vartotojui įvesti tris skaičius.Į ekraną išveskite šiuos skaičius ir jų vidurkį. 

            Console.WriteLine("Įveskite pirmą skaičių");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių");
            int trecias = Convert.ToInt32(Console.ReadLine());


            int vidurkis = (pirmas + antras + trecias) / 3;
            Console.WriteLine("{0},{1},{2} vidurkis: {3}", pirmas, antras, trecias, vidurkis);

            //Liepkite įvesti tris skaičius. Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu,
            //taip pat tuos skaičius, padalintus iš dviejų.

            Console.WriteLine("Įveskite pirmą skaičių");
            pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių");
            trecias = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Math.Pow(pirmas, 2));
            Console.WriteLine(Math.Pow(antras, 2));
            Console.WriteLine(Math.Pow(trecias, 2));
            Console.WriteLine(Math.Pow(pirmas, 3));
            Console.WriteLine(Math.Pow(antras, 3));
            Console.WriteLine(Math.Pow(trecias, 3));
            Console.WriteLine(pirmas/2);
            Console.WriteLine(antras/2);
            Console.WriteLine(trecias/2);
           




        }
    }
}
