using System;


namespace Uzduotis31
{
     internal class Program
    {
        static void Main(string[] args)
        {
            // Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą.
            //Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
            //Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.


            Program p = new Program();
            int skaicius1 = 10;
            int skaicius2 = 5;
            int skaicius3 = 15;
            Console.WriteLine(p.Suma(skaicius1, skaicius2, skaicius3));
            Console.WriteLine(p.Dalyba(skaicius1, skaicius2));
          
        }
        private int Suma(int b, int a, int c)
        {
            return b + a + c;
        }
        private double Dalyba(int b, int a)
        {
            return b / a ;
        }
        
    }
}
