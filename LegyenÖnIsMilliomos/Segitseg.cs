using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenÖnIsMilliomos
{
    internal static class Segitseg
    {
        public static List<string> Felezo(Kerdes kerdes)
        {
            char helyesBetu = kerdes.Megoldas.ToUpper()[0];
            int helyesIndex = 0;

            if (helyesBetu == 'A') helyesIndex = 0;
            else if (helyesBetu == 'B') helyesIndex = 1;
            else if (helyesBetu == 'C') helyesIndex = 2;
            else if (helyesBetu == 'D') helyesIndex = 3;

            List<int> rosszIndexek = new List<int> { 0, 1, 2, 3 };
            rosszIndexek.Remove(helyesIndex);

            Random r = new Random();
            int rosszIndex = rosszIndexek[r.Next(rosszIndexek.Count)];

            string[] betuk = { "A", "B", "C", "D" };
            return new List<string>
            {
                $"{betuk[helyesIndex]}: {kerdes.Valaszok[helyesIndex]}",
                $"{betuk[rosszIndex]}: {kerdes.Valaszok[rosszIndex]}"
                
            };
        }

        public static string Telefon(Kerdes kerdes)
        {
            char helyesBetu = kerdes.Megoldas.ToUpper()[0];
            int helyesIndex = 0;

            if (helyesBetu == 'A') helyesIndex = 0;
            else if (helyesBetu == 'B') helyesIndex = 1;
            else if (helyesBetu == 'C') helyesIndex = 2;
            else if (helyesBetu == 'D') helyesIndex = 3;

            Random r = new Random();
            int valasztottIndex;

            if (r.NextDouble() < 0.6)
            {
                valasztottIndex = helyesIndex;
            }
            else
            {
                List<int> rosszIndexek = new List<int> { 0, 1, 2, 3 };
                rosszIndexek.Remove(helyesIndex);
                valasztottIndex = rosszIndexek[r.Next(rosszIndexek.Count)];
            }

            string[] betuk = { "A", "B", "C", "D" };
            return $"Szerintem a helyes válasz: {betuk[valasztottIndex]} - {kerdes.Valaszok[valasztottIndex]}";

        }

        public static string Kozonseg(Kerdes kerdes)
        {
            char helyesBetu = kerdes.Megoldas.ToUpper()[0];
            int helyesIndex = 0;

            if (helyesBetu == 'A') helyesIndex = 0;
            else if (helyesBetu == 'B') helyesIndex = 1;
            else if (helyesBetu == 'C') helyesIndex = 2;
            else if (helyesBetu == 'D') helyesIndex = 3;

            Random r = new Random();
            int valasztottIndex;

            if (r.NextDouble() < 0.8)
            {
                valasztottIndex = helyesIndex;
            }
            else
            {
                List<int> rosszIndexek = new List<int> { 0, 1, 2, 3 };
                rosszIndexek.Remove(helyesIndex);
                valasztottIndex = rosszIndexek[r.Next(rosszIndexek.Count)];
            }

            string[] betuk = { "A", "B", "C", "D" };
            return $"A nézők szerint a szerint a helyes válasz: {betuk[valasztottIndex]} - {kerdes.Valaszok[valasztottIndex]}";

        }


    }
}
