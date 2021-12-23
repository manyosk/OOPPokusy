using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyoLibrary;
using MojDom;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            VytvorAVypisKnihy();

            VytvorAVypisDom();
            
            Console.ReadKey();
        }

        static private void VytvorAVypisKnihy()
        {
            SkrinaNaKnihy skrina = new SkrinaNaKnihy(5, 10);
            Console.WriteLine(skrina.MaxPocetKnihVSkrini());

            SkrinaNaKnihy skrina2 = new SkrinaNaKnihy(4, 8);
            Console.WriteLine(skrina2.MaxPocetKnihVSkrini());


            Kniha kniha1 = new Kniha("Hobbit", 1940);
            kniha1._cSkrina = skrina;
            Console.WriteLine(kniha1._cSkrina.MaxPocetKnihVSkrini());

            Kniha kniha2 = new Kniha("Harry Potter - Kamen mudrcov", 1996);
            kniha2._cSkrina = skrina2;
            Console.WriteLine(kniha2._cSkrina.MaxPocetKnihVSkrini());

            Kniha kniha3 = new Kniha("Harry Potter - Vezen z Azkabanu", 1999, skrina2);
            Console.WriteLine(kniha3._cSkrina.MaxPocetKnihVSkrini());

            Console.WriteLine(kniha2.VekKnihy());
            Console.WriteLine("Hello World!");
            Console.WriteLine();
        }
        
        static private void VytvorAVypisDom()
        {
            Dom dom1 = new Dom("Samorin", "Prva ulica", 72, "dom1");

            Poschodie poschodie1 = new Poschodie(1, "Prizemie");
            Poschodie poschodie2 = new Poschodie(2, "1. Poschodie");

            Izba izba1 = new Izba("obivacka", "Izba pre telku", 3.5f, 3.0f, 2.0f);
            Izba izba2 = new Izba("kuchina", "Kde pecieme tortu", 3.0f, 4.0f, 2.0f);
            Izba izba3 = new Izba("detska izba", "Kde su lega", 3.7f, 5.5f, 2.0f);
            Izba izba4 = new Izba("spalna", "Kde spi rodicia", 4.5f, 4.0f, 2.0f);

            dom1.v_poschodie1 = poschodie1;
            dom1.v_poschodie2 = poschodie2;

            poschodie1.v_izba1 = izba1;
            poschodie1.v_izba2 = izba2;

            poschodie2.v_izba1 = izba3;
            poschodie2.v_izba2 = izba4;

            dom1.VypisDom();
        }
    }
}
