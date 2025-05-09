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
		List<string> valaszok = new List<string>()
			;
	
		string megoldas;
		string kategoria;
		public Sor(string kerdes, string valasz1, string valasz2, string valasz3, string valasz4, string megoldas, string kategoria)
		{
			this.kerdes = kerdes;
			this.valaszok.Add(valasz1);
			this.valaszok.Add(valasz2);
			this.valaszok.Add(valasz3);
			this.valaszok.Add(valasz4);
			
			this.megoldas = megoldas;
			this.kategoria = kategoria;
		}

		public string Kerdes { get => kerdes; set => kerdes = value; }
	

		public string Megoldas { get => megoldas; set => megoldas = value; }
		public string Kategoria { get => kategoria; set => kategoria = value; }
		public List<string> Valaszok { get => valaszok; set => valaszok = value; }

	




		public override string? ToString()
		{
			return $"Kérdés: {kerdes}\n" +
				$"A: {valaszok[0],-30} B: {valaszok[1],-30}\n" +
				$"C: {valaszok[2],-30} D: {valaszok[3],-30}\n" +
				$"Kategória: {kategoria}, Megoldás: {megoldas}";
		}
	}
}
