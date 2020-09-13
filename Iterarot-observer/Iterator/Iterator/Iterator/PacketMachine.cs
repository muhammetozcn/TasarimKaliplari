using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class PacketMachine
    {
        Koli koli;
        public Koli uret()
        {
            koli = new Koli();
            return koli;
        }

        public Koli uret(string marka, int gramaj, string tur, int miktar)
        {
            koli= new Koli(marka, gramaj, tur, miktar);
            return koli;
        }
       
    }
}
