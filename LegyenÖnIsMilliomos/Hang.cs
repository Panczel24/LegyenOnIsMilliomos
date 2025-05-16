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

        private IWavePlayer hatterzene;
        private AudioFileReader zeneolvaso;

        public void HatterZene(string fajl)
        {
            zeneolvaso = new AudioFileReader(fajl);
            hatterzene = new WaveOutEvent();
            hatterzene.Init(zeneolvaso);
            hatterzene.Play();
        }

        public void Leallitas()
        {
            if (hatterzene != null)
            {
                hatterzene.Stop();
                hatterzene.Dispose();
                zeneolvaso.Dispose();
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
