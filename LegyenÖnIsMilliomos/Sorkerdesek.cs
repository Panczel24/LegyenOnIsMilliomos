using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenÖnIsMilliomos
{
	internal class Sorkerdesek
	{

		public void ReadFromFile()
		{
			List<Sor> sorkerdes = [];

			StreamReader sr = new StreamReader("sorkerdes.txt");
			sr.ReadLine();


			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine() ?? "";
				string[] szavak = sor.Split(';');

				Sor ujsor = new(szavak[0], szavak[1], szavak[2],szavak[3], szavak[4], szavak[5], szavak[6]);

				sorkerdes.Add(ujsor);

				this.Kiiras( sorkerdes);

			}

			for (int i = 0; i < sorkerdes.Count; i++)
			{
				Console.WriteLine(sorkerdes[i]);
            }
		}

		


	public void Kiiras(List<Sor> sorkerdes)
	{

		for (int i = 0; i < sorkerdes.Count; i++)
		{
			Console.WriteLine(sorkerdes[i]);
		}
	}

	}

}
