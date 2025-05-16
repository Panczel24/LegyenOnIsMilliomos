using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using NAudio.Wave;

namespace LegyenÖnIsMilliomos
{
    internal class Kerdessor
    {       
        public static List<List<Kerdes>> KerdesCsoport { get; private set; } = new();
        List<Kerdes> kerdessor = new List<Kerdes>();
        List<Kerdes> kerdessor1 = new List<Kerdes>();
        List<Kerdes> kerdessor2 = new List<Kerdes>();
        List<Kerdes> kerdessor3 = new List<Kerdes>();
        List<Kerdes> kerdessor4 = new List<Kerdes>();
        List<Kerdes> kerdessor5 = new List<Kerdes>();
        List<Kerdes> kerdessor6 = new List<Kerdes>();
        List<Kerdes> kerdessor7 = new List<Kerdes>();
        List<Kerdes> kerdessor8 = new List<Kerdes>();
        List<Kerdes> kerdessor9 = new List<Kerdes>();
        List<Kerdes> kerdessor10 = new List<Kerdes>();
        List<Kerdes> kerdessor11 = new List<Kerdes>();
        List<Kerdes> kerdessor12 = new List<Kerdes>();
        List<Kerdes> kerdessor13 = new List<Kerdes>();
        List<Kerdes> kerdessor14 = new List<Kerdes>();
        List<Kerdes> kerdessor15 = new List<Kerdes>();


        public Kerdessor()
        {
            ReadFromFile();
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
                switch (sorszam)
                {
                    case 1: kerdessor1.Add(ujsor); break;
                    case 2: kerdessor2.Add(ujsor); break;
                    case 3: kerdessor3.Add(ujsor); break;
                    case 4: kerdessor4.Add(ujsor); break;
                    case 5: kerdessor5.Add(ujsor); break;
                    case 6: kerdessor6.Add(ujsor); break;
                    case 7: kerdessor7.Add(ujsor); break;
                    case 8: kerdessor8.Add(ujsor); break;
                    case 9: kerdessor9.Add(ujsor); break;
                    case 10: kerdessor10.Add(ujsor); break;
                    case 11: kerdessor11.Add(ujsor); break;
                    case 12: kerdessor12.Add(ujsor); break;
                    case 13: kerdessor13.Add(ujsor); break;
                    case 14: kerdessor14.Add(ujsor); break;
                    case 15: kerdessor15.Add(ujsor); break;
                }
            }
            KerdesCsoport.Add(kerdessor1);
            KerdesCsoport.Add(kerdessor2);
            KerdesCsoport.Add(kerdessor3);
            KerdesCsoport.Add(kerdessor4);
            KerdesCsoport.Add(kerdessor5);
            KerdesCsoport.Add(kerdessor6);
            KerdesCsoport.Add(kerdessor7);
            KerdesCsoport.Add(kerdessor8);
            KerdesCsoport.Add(kerdessor9);
            KerdesCsoport.Add(kerdessor10);
            KerdesCsoport.Add(kerdessor11);
            KerdesCsoport.Add(kerdessor12);
            KerdesCsoport.Add(kerdessor13);
            KerdesCsoport.Add(kerdessor14);
            KerdesCsoport.Add(kerdessor15);
        }        
    }
}
