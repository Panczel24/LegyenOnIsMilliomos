using System.Collections.Generic;

namespace LegyenÖnIsMilliomos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorkerdesek sorkerdesek = new Sorkerdesek();
            sorkerdesek.SorkerdesValasztasa();
            
            sorkerdesek.ReadFromFile();
            Kerdessor kerdessor = new Kerdessor();
            kerdessor.KerdessorElkeszites();

            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
