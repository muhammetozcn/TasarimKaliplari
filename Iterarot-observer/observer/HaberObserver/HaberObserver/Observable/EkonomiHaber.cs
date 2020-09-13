using HaberObserver.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberObserver
{
    public class EkonomiHaber : Haber
    {
        string mesaj;
        List<IAbone> aboneListesi;
        static EkonomiHaber instance;
        private EkonomiHaber()
        {
            aboneListesi = new List<IAbone>();
            mesaj = "Ekonomi haberleri güncellenmiştir";
        }

        public static EkonomiHaber getInstance()
        {
            if (instance == null)
            {
                instance = new EkonomiHaber();
            }
            return instance;
            
        }



        public void notifyObserver()
        {
            lock (this) {
                foreach (var abone in aboneListesi)
                {
                    abone.update("Ekonomi haberleri güncellenmiştir");
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
