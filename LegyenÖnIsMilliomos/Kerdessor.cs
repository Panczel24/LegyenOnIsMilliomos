using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenÖnIsMilliomos
{
    internal class Kerdessor
    {
        public List<List<Kerdes>> KerdesCsoportok { get; private set; } = new();
        List<Kerdes> kerdessor = new List<Kerdes>();
        static Random r = new Random();

        public Kerdessor()
        {

            ReadFromFile();
            //Kiiras();
        }


        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader("kerdes.txt");
            List<Kerdes> aktualisLista = new();

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "";
                string[] szavak = sor.Split(';');
                int sorszam = int.Parse(szavak[0]);
                Kerdes ujsor = new(sorszam, szavak[1], szavak[2], szavak[3], szavak[4], szavak[5], szavak[6], szavak[7]);

                if (sorszam == 1 && aktualisLista.Count > 0)
                {
                    KerdesCsoportok.Add(aktualisLista);
                    aktualisLista = new();
                }

                aktualisLista.Add(ujsor);

            }
                if (aktualisLista.Count > 0)
                {
                    KerdesCsoportok.Add(aktualisLista);
                }
        }


        public void Kerdessorelkeszites()
        {
            for (int i = 0; i < KerdesCsoportok.Count; i++)
            {
                List<Kerdes> aktualisCsoport = KerdesCsoportok[i];
                int veletlenIndex = r.Next(aktualisCsoport.Count);
                Kerdes kerdes = aktualisCsoport[veletlenIndex];

                Console.WriteLine($"\nKérdés a(z) {i + 1}. csoportból");
                Console.WriteLine(kerdes);
                Console.Write("Adja meg a jó választ (A, B, C, D): ");
                string valasz = Console.ReadLine().ToUpper();

                if (valasz != kerdes.Megoldas.ToUpper())
                {
                    Console.WriteLine("Sikertelen, játék vége!");
                   
                }
                else
                {
                    Console.WriteLine("Helyes válasz! Tovább léphet a következő szintre.");
                }
            }

            Console.WriteLine("Gratulálok, az összes szintet sikeresen teljesítetted!");
           
        }

    }
}
