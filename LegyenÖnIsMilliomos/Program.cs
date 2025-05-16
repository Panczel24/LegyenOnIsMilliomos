using System.Collections.Generic;

namespace LegyenÖnIsMilliomos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kedves játékos! A mai napi Legyen Ön Is Milliomos játékban megnézheti, mennyi pénzt tud bezsebelni csupán kérdések megválaszolásával");
            Console.WriteLine("A játék menete így fog lezajlani:" +
                "\nElőször felteszünk egy kérdést, amely eldönti, hogy bekerülhet-e a játékba" +
                "\n Akérdések mindig nehzebbek lesznek az előzőnél" +
                "\nMinden helyes kérdés százezer forintot ér, viszont csak bizonyos összegeknél van biztos jövedelem" +
                "\nEzek az összegek a háromszázezer-hatszázezer-kilencszázezer-egymilliókétszázezer-és másfél millió forintok." +
                "\nHa például kétszázezer forintnál kiesik, akkor sajnos nem nyert semmit.");
            Console.WriteLine("Jó játékot kívánok!");
            Console.ReadLine();
            Sorkerdesek sorkerdesek = new Sorkerdesek();
            sorkerdesek.ReadFromFile();

            if (sorkerdesek.SorkerdesValasztasa())
            {
                Kerdessor kerdessor = new Kerdessor();
                kerdessor.KerdessorElkeszites();
            }
            else
            {
                Console.WriteLine("Sajnos hibás volt a válasz, nem mehetsz tovább, vége a játéknak.");
            }


            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
