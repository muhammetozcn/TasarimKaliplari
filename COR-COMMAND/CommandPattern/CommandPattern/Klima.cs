using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Klima
    {
        private string marka;
        private bool klimaAcikMi;
        private int klimaSicaklik = 25;

        public Klima(string marka)
        {
            this.marka = marka;
        }
        public void On()
        {
            Console.WriteLine("Klima açıldı sinyal sesi...");
            this.klimaAcikMi = true;
        }
        public void Off()
        {
            Console.WriteLine("Klima kapanış sesi...");
            this.klimaAcikMi = false;
        }
        private bool getKlimaStatus()
        {
            return this.klimaAcikMi;
        }
        public void IncreaseTemp()
        {
            if (getKlimaStatus())
            {
                this.klimaSicaklik++;
                Console.WriteLine("Klima Sicakligi:" + this.klimaSicaklik);

            }
            else
            {
                Console.WriteLine("Klima kapali sicaklik arttirilamiyor");
            }
        }
        public void DecreaseTemp()
        {
            if (getKlimaStatus())
            {
                this.klimaSicaklik = this.klimaSicaklik - 1;
                Console.WriteLine("Klima Sicakligi:" + this.klimaSicaklik);
            }
            else
            {
                Console.WriteLine("Klima kapali sicaklik azaltilamiyor");
            }

        }
    }

}
