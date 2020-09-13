using HaberObserver.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HaberObserver
{
    class Program
    {
        public static void EkonomiHaberAboneOl(string threadName)
        {
            Abone abone = new Abone(threadName);
            abone.AboneOlEkonomi();
        }
        public static Abone SporHaberAboneOl(string threadName)
        {
            Abone abone = new Abone(threadName);
            abone.AboneOlSpor();
            return abone;
        }
        static Abone abone1;
        static  Abone abone3;
        static Abone abone5;
        static void Main(string[] args)
        {
            SporHaber shaber = SporHaber.getInstance();
            EkonomiHaber ehaber = EkonomiHaber.getInstance();

            #region thread 1,3,5
            Thread th1 = new Thread(() => abone1 = SporHaberAboneOl("th1"));
            Thread th3 = new Thread(() => abone3 = SporHaberAboneOl("th3"));
            Thread th5 = new Thread(() => abone5 = SporHaberAboneOl("th5"));
            th1.Start();th3.Start(); th5.Start();
            #endregion

            #region thread 2,4,6
            Thread th2 = new Thread(() => EkonomiHaberAboneOl("th2"));
            Thread th4 = new Thread(() => EkonomiHaberAboneOl("th4"));
            Thread th6 = new Thread(() => EkonomiHaberAboneOl("th6"));
            th2.Start(); th4.Start(); th6.Start();
            #endregion


            ehaber.notifyObserver();
            Console.WriteLine("------------------");
            shaber.notifyObserver();

            #region Abone1 Spor haberlerinden ayrılıyor
            Console.WriteLine("-------------");
            abone1.AbonelikSilSpor();
            shaber.notifyObserver();
            #endregion

            #region Abone3 Ekonomi haberlerini ekliyor
            abone3.AboneOlEkonomi();
            Console.WriteLine("--------------");
            ehaber.notifyObserver();
            #endregion






            Console.Read();


        }
    }
}
