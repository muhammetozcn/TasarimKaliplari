using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKirala
{
    //PoolManager
    public class Galeri
    {

        private static Galeri instance = null;
        private int AracKapasite { get; set; } = 5;

        public List<Araba> carPool = new List<Araba>();

        private static readonly object Instancelock = new object();

        private Galeri()
        {
            init();

        }
        private void init()
        {
            for (int i = 0; i < AracKapasite; i++)
            {
                carPool.Add(new Araba(i, "Renault", "Symbol", "2016", 80));
            }

        }
        public void sonradanAracEkle()
        {
            lock (carPool)
            {
                carPool.Add(new Araba(carPool.Count, "Renault", "megan", "2018", 120));
            }
           
        }

        public static Galeri GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Galeri();
                    }
                    return instance;
                }
            }
        }
        public Araba AracKirala(string sahip)
        {
            lock (this)
            {
                foreach (var araba in carPool)
                {

                    if (String.IsNullOrEmpty(araba.aracSahibi))
                    {
                       
                        Console.WriteLine("Thread Name:" + sahip + " Araba Model:"
                            + araba.Model + " Araba Id:" + araba.id + " Arac satın alındı.");
                        araba.aracSahibi = sahip;
                        return araba;
                        //break;

                    }
                }
                Console.WriteLine(sahip + " Araba alamadı.Çünkü tüm arabalar dolu");
                return null;
            }
        }
        public void GaleriyeGeriVer(string sahip)
        {
            lock (sahip)
            {
                foreach (var araba in carPool)
                {
                    if (araba.aracSahibi.Equals(sahip))
                    {
                        araba.aracSahibi = "";
                        Console.WriteLine(araba.id + " Numaralı arac geri verildi. " + sahip + " tarafından");
                    }
                }
            }
        }
    }
}
