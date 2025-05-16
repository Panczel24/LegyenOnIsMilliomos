using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenÖnIsMilliomos
{
    internal class Kerdes
    {
        List<string> kerdesvalaszok = new List<string>();
        int sorszam;
        string kerdes;
        string megoldas;
        string kategoria;
        public Kerdes(int sorszam, string kerdes, string valasz1, string valasz2, string valasz3, string valasz4, string megoldas, string kategoria)
        {
            this.sorszam = sorszam;
            this.kerdes = kerdes;

            this.kerdesvalaszok.Add(valasz1);
            this.kerdesvalaszok.Add(valasz2);
            this.kerdesvalaszok.Add(valasz3);
            this.kerdesvalaszok.Add(valasz4);

            this.megoldas = megoldas;
            this.kategoria = kategoria;
        }

        public int Sorszam { get => sorszam; set => sorszam = value; }
        public string Kerdesvalaszok { get => kerdes; set => kerdes = value; }
        public string Megoldas { get => megoldas; set => megoldas = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public List<string> Valaszok { get => kerdesvalaszok; set => kerdesvalaszok = value; }






        public override string? ToString()
        {
            return $"Kérdés: {kerdes}\n" +
                $"A: {kerdesvalaszok[0],-30} B: {kerdesvalaszok[1],-30}\n" +
                $"C: {kerdesvalaszok[2],-30} D: {kerdesvalaszok[3],-30}\n" +
                $"Kategória: {kategoria}, Megoldás: {megoldas}";
        }
    }
}

