using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)

        { // Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. Raskite:
          //  mažiausią skaičių;
          //  didžiausią skaičių;
          //  vidurkį;
          // kiek skaičių yra žemesni už vidurkį;
          // lyginių skaičių sumą;

            List<int> skaiciai = new List<int>();
            
            Random randomGen = new Random();
            int sarasoIlgis = randomGen.Next(10, 70);
            int kiekisMazesniuUzVidurki = 0;
            int sumaLyginiuSkaiciu = 0;

            for (int i = 0; i < 100; i++) ;
            skaiciai.Add(randomGen.Next(1, 100));

            foreach (int skaicius in skaiciai)

            {
                Console.Write($"{skaicius} ");
                if (skaicius < skaiciai.Average()) kiekisMazesniuUzVidurki++;
                if (skaicius % 2 == 0) sumaLyginiuSkaiciu += skaicius;
            }
            Console.WriteLine();

            Console.WriteLine($"Elementų kiekis: {sarasoIlgis}");
            Console.WriteLine($"Maziausias skaicius: {skaiciai.Min()}");
            Console.WriteLine($"Didziausias skaicius: {skaiciai.Max()}");
            Console.WriteLine($"Vidurkis: {skaiciai.Average()}");
            Console.WriteLine($"kiek skaičių yra žemesni už vidurkį: {kiekisMazesniuUzVidurki}");
            Console.WriteLine($"lyginių skaičių sumą: {sumaLyginiuSkaiciu}");
    }
        }
        
}
    

