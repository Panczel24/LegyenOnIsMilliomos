using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;


namespace LegyenÖnIsMilliomos
{
    internal class Jatek
    {
        static Random r = new Random();

        public static void Jatszijatszi()
        {

            Console.WriteLine("Kedves játékos! A mai napi Legyen Ön Is Milliomos játékban megnézheti, mennyi pénzt tud bezsebelni csupán kérdések megválaszolásával");
            Console.WriteLine("A játék menete így fog lezajlani:" +
                "\nElőször felteszünk egy kérdést, amely eldönti, hogy bekerülhet-e a játékba" +
                "\n Akérdések mindig nehzebbek lesznek az előzőnél" +
                "\nMinden helyes kérdés százezer forintot ér, viszont csak bizonyos összegeknél van biztos jövedelem" +
                "\nEzek az összegek a háromszázezer-hatszázezer-kilencszázezer-egymilliókétszázezer-és másfél millió forintok." +
                "\nHa például kétszázezer forintnál kiesik, akkor sajnos nem nyert semmit.");
            Console.WriteLine("Jó játékot kívánok! (nyomj entert az indításhoz)");
            Console.ReadLine();
            Sorkerdesek sorkerdesek = new Sorkerdesek();
            sorkerdesek.ReadFromFile();


            if (sorkerdesek.SorkerdesValasztasa())
            {
                List<string> segitsegTipusok = new List<string> { "felező", "telefon", "közönség" };
                Thread.Sleep(2000);
                var hang = new Hang();
                hang.HatterZene("izgalom.wav");
                int penz = 0;
                int biz3 = 300000;
                int biz6 = 600000;
                int biz9 = 900000;
                int biz12 = 1200000;
                int max = 1500000;
                int biztosmegvan = 0;

                Kerdessor kerdessor = new Kerdessor();
                kerdessor.ReadFromFile();

                for (int i = 0; i < Kerdessor.KerdesCsoport.Count; i++)
                {
                    var aktualisCsoport = Kerdessor.KerdesCsoport[i];
                    int veletlenIndex = r.Next(aktualisCsoport.Count);
                    Kerdes kerdes = aktualisCsoport[veletlenIndex];

                    Console.WriteLine($"\n{i + 1}. kérdés");
                    Console.WriteLine(kerdes);
                    Console.WriteLine("Kér segítséget? (nem, " + string.Join(", ", segitsegTipusok) + ")");
                    string kere = Console.ReadLine().ToLower();
                    if (kere == "nem")
                    {
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
                            if (penz == biz3 || penz == biz6 || penz == biz9 || penz == biz12)
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
                            if (penz == max)
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
                            hang.Effektus("rossz.wav");
                            Thread.Sleep(2000);
                            hang.Leallitas();
                            return;
                        }
                    }
                    else if (kere == "felező")
                    {
                        var felezoValaszok = Segitseg.Felezo(kerdes);
                        segitsegTipusok.Remove("felező");
                        Console.WriteLine("Felező segítség aktiválva! Két válaszlehetőség maradt:");

                        foreach (var felezovalasz in felezoValaszok)
                        {
                            Console.WriteLine(felezovalasz);
                        }

                        Console.Write($"Add meg a válaszod: ");
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
                            if (penz == biz3 || penz == biz6 || penz == biz9 || penz == biz12)
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
                            if (penz == max)
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
                            hang.Effektus("rossz.wav");
                            Thread.Sleep(2000);
                            hang.Leallitas();
                            return;
                        }
                    }
                    else if (kere == "telefon")
                    {
                        segitsegTipusok.Remove("telefon");
                        Console.WriteLine("Telefonos segítség aktiválva....*telefonbeszélgetés*");
                        Console.WriteLine(Segitseg.Telefon(kerdes));
                        Console.Write("Add meg a válaszod: ");
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
                            if (penz == biz3 || penz == biz6 || penz == biz9 || penz == biz12)
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
                            if (penz == max)
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
                            hang.Effektus("rossz.wav");
                            Thread.Sleep(2000);
                            hang.Leallitas();
                            return;
                        }
                    }
                    else if (kere == "közönség")
                    {
                        segitsegTipusok.Remove("közönség");
                        Console.WriteLine("Közönség segítsége....*nézők szavaznak*");
                        Console.WriteLine(Segitseg.Kozonseg(kerdes));
                        Console.Write("Add meg a válaszod: ");
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
                            if (penz == biz3 || penz == biz6 || penz == biz9 || penz == biz12)
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
                            if (penz == max)
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
                            hang.Effektus("rossz.wav");
                            Thread.Sleep(2000);
                            hang.Leallitas();
                            return;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Ilyet vagy elhasználtál, vagy elírtál valamit");                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Sajnos hibás volt a válasz, nem mehetsz tovább, vége a játéknak.");
            }


            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();


            

        }
    }
}
