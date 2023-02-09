using System;


namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mano vardas: Arune");

            string vardas = "Arune";
            Console.Write("Mano vardas: ");
            Console.WriteLine(vardas);

            Console.WriteLine("Mano vardas: " + "Arune");
            Console.WriteLine("Mano vardas: {0}, {1}", vardas, "S"); // galima pateigti tiesiog reiksme 

            Console.WriteLine($"Mano vardas: {vardas}"); // geriausias budas

            Console.WriteLine(); // tuscia eilute
            Console.WriteLine("Nauja eilute galima  \n iterpti ir taip");

        }
    }
}
