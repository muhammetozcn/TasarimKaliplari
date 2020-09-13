using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberObserver
{
    //observable
    public interface Haber
    {
        void registerObserver(IAbone abone);
        void unregisterObserver(IAbone abone);
        void notifyObserver();
   



    }
}
