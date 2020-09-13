using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberObserver.Observer
{
    public class Abone : IAbone
    {
        
        public string threadName;
        private EkonomiHaber ehaber;
        private SporHaber shaber;

        public Abone(string name)
        {
            ehaber = EkonomiHaber.getInstance();
            shaber = SporHaber.getInstance();
            this.threadName = name;
        }

        public Abone()
        {
        }


        //Bu methodu sadece publisher çağırcak.
        public void update(string mesaj)
        {
            Console.WriteLine(threadName+" "+mesaj);
        }
      
        public void AboneOlEkonomi()
        {
           
            ehaber.registerObserver(this);
        }
        public void AboneOlSpor()
        {
           
            shaber.registerObserver(this);
        }
       
        public void AbonelikSilSpor()
        {
            shaber.unregisterObserver(this);
        }
        public void AbonelikSilEkonomi()
        {
            ehaber.unregisterObserver(this);
        }




    }
}
