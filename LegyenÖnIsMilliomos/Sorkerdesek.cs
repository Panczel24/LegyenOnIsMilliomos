using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using NAudio.Wave;

namespace LegyenÖnIsMilliomos
{
	internal class Sorkerdesek
	{

        List<Sor> sorkerdes = new List<Sor>();
		static Random r = new Random();

		public Sorkerdesek()
		{

			ReadFromFile();
			//Kiiras();
		}


		public void ReadFromFile()
		{
			StreamReader sr = new StreamReader("sorkerdes.txt");
			sr.ReadLine();


			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine() ?? "";
				string[] szavak = sor.Split(';');

				Sor ujsor = new(szavak[0], szavak[1], szavak[2], szavak[3], szavak[4], szavak[5], szavak[6]);

				sorkerdes.Add(ujsor);

			}
		}


		public bool SorkerdesValasztasa()
		{
            var hang = new Hang();

            bool joe = false;
			int veletlen = r.Next(0, sorkerdes.Count);
			Console.WriteLine(sorkerdes[veletlen]);

            Console.WriteLine("Adja meg a jó sorrendet: ");
			string valasz = Console.ReadLine().ToUpper();
			if (valasz == sorkerdes[veletlen].Megoldas)
			{
                hang.Effektus("jo.wav");
				Console.WriteLine("Sikeres, továbbléphet a játékra!");
				joe = true;
            }
			else
			{
                hang.Effektus("rossz.wav");
				joe = false;
            }

			return joe;

        }

	}

}
