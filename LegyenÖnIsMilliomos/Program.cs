using System.Collections.Generic;

namespace LegyenÖnIsMilliomos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Sorkerdesek sorkerdesek = new Sorkerdesek();
			sorkerdesek.SorkerdesValasztasa();
            //Kerdessor kerdessor = new Kerdessor();
            //kerdessor.KerdessorValasztasa();
            //sorkerdesek.ReadFromFile();

            Kerdessor k = new();
            k.ReadFromFile();

            for (int i = 0; i < k.KerdesCsoportok.Count; i++)
            {
                Console.WriteLine($"Csoport {i + 1}:");
                foreach (var kerdes in k.KerdesCsoportok[i])
                {
                    Console.WriteLine(kerdes);
                }
            }
        }
	}
}
