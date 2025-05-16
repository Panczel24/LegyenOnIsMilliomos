using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace LegyenÖnIsMilliomos
{
    internal class Hang
    {
        private WaveOutEvent hatterzene;
        private AudioFileReader zeneolvaso;
        private string aktualisFajl;

        public void HatterZene(string fajl)
        {
            aktualisFajl = fajl;

            if (hatterzene != null)
            {
                hatterzene.Stop();
                hatterzene.Dispose();
                zeneolvaso.Dispose();
            }

            zeneolvaso = new AudioFileReader(fajl);
            hatterzene = new WaveOutEvent();
            hatterzene.Init(zeneolvaso);
            hatterzene.PlaybackStopped += Hatterzene_LejatszasVege;
            hatterzene.Play();
        }

        private void Hatterzene_LejatszasVege(object sender, StoppedEventArgs e)
        {
            // Újraindítjuk a zenét teljes újrainicializálással
            Task.Run(() =>
            {
                try
                {
                    Thread.Sleep(100); // Kis késleltetés, hogy elkerüljük az ütközést
                    HatterZene(aktualisFajl);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a háttérzene újraindításakor: " + ex.Message);
                }
            });
        }

        public void Leallitas()
        {
            if (hatterzene != null)
            {
                hatterzene.Stop();
                hatterzene.Dispose();
                zeneolvaso.Dispose();
                hatterzene = null;
                zeneolvaso = null;
            }
        }

        public void Effektus(string fajl)
        {
            Task.Run(() =>
            {
                using var reader = new AudioFileReader(fajl);
                using var outputDevice = new WaveOutEvent();
                outputDevice.Init(reader);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            });
        }

    }
}
