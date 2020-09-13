using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberObserver
{
    public class SporHaber : Haber
    {
        string mesaj;
        List<IAbone> aboneListesi;
        public static SporHaber instance;
        private SporHaber()
        {
            aboneListesi = new List<IAbone>();
        }
        public static SporHaber getInstance()
        {
            if (instance == null)
            {
                instance = new SporHaber();
            }
            return instance;
        }




        public void notifyObserver()
        {
            lock (this)
            {
                foreach (var abone in aboneListesi)
                {
                    abone.update("Spor haberleri güncellenmiştir");
                }
            }
        }

        public void registerObserver(IAbone abone)
        {
            aboneListesi.Add(abone);
        }

        public void unregisterObserver(IAbone abone)
        {
            aboneListesi.Remove(abone);
        }
     
    }
}
