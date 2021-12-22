using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyoLibrary;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrinaNaKnihy skrina = new SkrinaNaKnihy(5, 10);
            Console.WriteLine(skrina.MaxPocetKnihVSkrini());

            SkrinaNaKnihy skrina2 = new SkrinaNaKnihy(4, 8);
            Console.WriteLine(skrina2.MaxPocetKnihVSkrini());


            Kniha kniha1 = new Kniha("Hobbit", 1940);
            kniha1.SetSkrina(skrina);
            Console.WriteLine(kniha1._skrina.MaxPocetKnihVSkrini());

            Kniha kniha2 = new Kniha("Harry Potter - Kamen mudrcov", 1996);
            kniha2.SetSkrina(skrina2);
            Console.WriteLine(kniha2._skrina.MaxPocetKnihVSkrini());

            Kniha kniha3 = new Kniha("Harry Potter - Vezen z Azkabanu", 1999, skrina2);
            Console.WriteLine(kniha3._skrina.MaxPocetKnihVSkrini());

            Console.WriteLine(kniha2.VekKnihy());
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }

        
    }
}
