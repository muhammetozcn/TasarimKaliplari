using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AracKirala
{
    class Program
    {
        private static void GaleriyeGit(Galeri galeri, Araba arabam, string threadName)
        {
            while (true)
            {
                Thread.Sleep(1000);
                arabam = galeri.AracKirala(threadName);

                if (arabam != null)
                {
                    break;
                }
            }
        }
        private static void ArabaKirala(string threadName)
        {
            Galeri galeri = Galeri.GetInstance;
            Araba arabam = galeri.AracKirala(threadName);
            if (arabam == null)
            {
                GaleriyeGit(galeri, arabam, threadName);
            }
            Thread.Sleep(3000);
            ArabaGeriVer(threadName);


        }
        private static void ArabaGeriVer(string threadName)
        {
            Galeri galeri = Galeri.GetInstance;
            galeri.GaleriyeGeriVer(threadName);
        }

        private static void Main(string[] args)
        {
            Galeri galeri = Galeri.GetInstance;


            Thread th1 = new Thread(() => ArabaKirala("th1"));
            th1.Start();
            Thread th2 = new Thread(() => ArabaKirala("th2"));
            th2.Start();

            Thread th3 = new Thread(() => ArabaKirala("th3"));
            th3.Start();

            Thread th4 = new Thread(() => ArabaKirala("th4"));
            th4.Start();

            Thread th5 = new Thread(() => ArabaKirala("th5"));
            th5.Start();

            Thread th6 = new Thread(() => ArabaKirala("th6"));
            th6.Start();
            Thread th7 = new Thread(() => ArabaKirala("th7"));
            th7.Start();
            Thread th8 = new Thread(() => ArabaKirala("th8"));
            th8.Start();
            Thread th9 = new Thread(() => ArabaKirala("th9"));
            th9.Start();
            galeri.sonradanAracEkle();
            Thread th10 = new Thread(() => ArabaKirala("th10"));
            th10.Start();

            Thread th11 = new Thread(() => ArabaKirala("th11"));
            th11.Start();




            Console.ReadLine();
        }

    }

}