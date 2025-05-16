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
            sr.ReadLine();
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
                if (aktualisLista.Count > 0)
                {
                    KerdesCsoportok.Add(aktualisLista);
                }

                aktualisLista.Add(ujsor);

            }
        }


        public void KerdessorValasztasa()
        {
            int veletlen = r.Next(0, kerdessor.Count);
            Console.WriteLine(kerdessor[veletlen]);

            Console.WriteLine("Adja meg a jó választ: ");
            string valasz = Console.ReadLine().ToUpper();
            if (valasz == kerdessor[veletlen].Megoldas)
            {
                Console.WriteLine("Sikeres, továbbléphet a következő szintre!");
            }
            else
            {

                Console.WriteLine("Sikertelen, játék vége!");
            }

           

        }
    }
}
