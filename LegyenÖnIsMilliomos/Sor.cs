using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenÖnIsMilliomos
{
	internal class Sor
	{
		string kerdes;
		string valasz1;
		string valasz2;
		string valasz3;
		string valasz4;
		string megoldas;
		string kategoria;

		public Sor(string kerdes, string valasz1, string valasz2, string valasz3, string valasz4, string megoldas, string kategoria)
		{
			this.kerdes = kerdes;
			this.valasz1 = valasz1;
			this.valasz2 = valasz2;
			this.valasz3 = valasz3;
			this.valasz4 = valasz4;
			this.megoldas = megoldas;
			this.kategoria = kategoria;
		}

		public string Kerdes { get => kerdes; set => kerdes = value; }
		public string Valasz1 { get => valasz1; set => valasz1 = value; }
		public string Valasz2 { get => valasz2; set => valasz2 = value; }
		public string Valasz3 { get => valasz3; set => valasz3 = value; }
		public string Valasz4 { get => valasz4; set => valasz4 = value; }
		public string Megoldas { get => megoldas; set => megoldas = value; }
		public string Kategoria { get => kategoria; set => kategoria = value; }

		public override string? ToString()
		{
			return $"Kérdés: {kerdes}, \n lehetőség1: {valasz1},  lehetőség2: {valasz2}, lehetőség3: {valasz3}, lehetőség4: {valasz4}, megoldas: {megoldas}, kategória> {kategoria}" ;
		}
	}
}
