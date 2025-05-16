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

        

       
        public List<List<Kerdes>> KerdesCsoport { get; private set; } = new();
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

        static Random r = new Random();

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
                if (sorszam == 1)
                {
                    kerdessor1.Add(ujsor);
                }
                if (sorszam == 2)
                {
                    kerdessor2.Add(ujsor);
                }
                if (sorszam == 3)
                {
                    kerdessor3.Add(ujsor);
                }
                if (sorszam == 4)
                {
                    kerdessor4.Add(ujsor);
                }
                if (sorszam == 5)
                {
                    kerdessor5.Add(ujsor);
                }
                if (sorszam == 6)
                {
                    kerdessor6.Add(ujsor);
                }
                if (sorszam == 7)
                {
                    kerdessor7.Add(ujsor);
                }
                if (sorszam == 8)
                {
                    kerdessor8.Add(ujsor);
                }
                if (sorszam == 9)
                {
                    kerdessor9.Add(ujsor);
                }
                if (sorszam == 10)
                {
                    kerdessor10.Add(ujsor);
                }
                if (sorszam == 11)
                {
                    kerdessor11.Add(ujsor);
                }
                if (sorszam == 12)
                {
                    kerdessor12.Add(ujsor);
                }
                if (sorszam == 13)
                {
                    kerdessor13.Add(ujsor);
                }
                if (sorszam == 14)
                {
                    kerdessor14.Add(ujsor);
                }
                if (sorszam == 15)
                {
                    kerdessor15.Add(ujsor);
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
            //rájöttem, hogy az előző változattal egy picit NAGYON sok kérdés lenne, és nem így kell megcsinálni, szóval újratervezés volt (┬┬﹏┬┬)


        public void KerdessorElkeszites()
        {
           Thread.Sleep(2000);
            var hang = new Hang();
            hang.HatterZene("izgalom.wav");
            int penz = 0;
            int biz3 = 300000;
            int biz6= 600000;
            int biz9 = 900000;    
            int biz12 = 1200000;
            int max = 1500000;
            int biztosmegvan = 0;
            for (int i = 0; i < KerdesCsoport.Count; i++)
            {
                List<Kerdes> aktualisCsoport = KerdesCsoport[i];
                int veletlenIndex = r.Next(aktualisCsoport.Count);
                Kerdes kerdes = aktualisCsoport[veletlenIndex];

                Console.WriteLine($"\n{i + 1}. kérdés");
                Console.WriteLine(kerdes);
                Console.Write("Adja meg a jó választ (A, B, C, D): ");
                string valasz = Console.ReadLine().ToUpper();

                if (valasz == kerdes.Megoldas.ToUpper())
                {
                    Console.WriteLine("Helyes válasz!");
                    penz += 100000;
                    Console.WriteLine($"Eddig ennyi pénzt szereztél:{penz}");
                    if (penz != biz3 && penz != biz6 && penz != biz9 && penz != biz12)
                    {
                        hang.Effektus("jo.wav");
                    }
                    if (penz == biz3 || penz ==biz6 || penz ==biz9 || penz ==biz12)
                    {
                        hang.Effektus("biztos.wav");
                        Console.WriteLine("Gratulálok, egy biztos nyereményhez értél!");
                        Thread.Sleep(4000);
                    }
                    if (penz == biz3)
                    {
                        biztosmegvan = biz3;
                    }
                    if (penz == biz6)
                    {
                        biztosmegvan = biz6;
                    }
                    if (penz == biz9)
                    {
                        biztosmegvan = biz9;
                    }
                    if (penz == biz12)
                    {
                        biztosmegvan = biz12;
                    }
                    if (penz==max)
                    {
                        Console.WriteLine("Gratulálok, megnyerte az egymillió-ötszázezer forintot!");
                        hang.Leallitas();
                        hang.Effektus("vege.wav");
                    }

                }
                else
                {
                    Console.WriteLine($"Sajnos rossz választ adtál, a játékot nem folytathatod" +
                        $"\nA biztos nyereményed:{biztosmegvan}");
                    hang.Leallitas();
                    hang.Effektus("rossz.wav");
                    return;
                }
            }           
        }
    }
}
